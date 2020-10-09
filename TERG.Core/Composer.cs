using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TERG.Core.Interfaces;
using TERG.Core.Models;

namespace TERG.Core
{
    public class Composer
    {
        public enum HeaderAndFooterSetting
        {
            ALL,
            FIRST_LAST,
            NONE
        }

        private readonly Engine e;

        private Composer()
        { }

        internal Composer(Engine engine)
        {
            e = engine;
        }

        public List<string> Compose(Pattern p, int i, HeaderAndFooterSetting hf) =>
            Compose(new JobSettings() { Pattern = p, Iterations = i, HeaderAndFooter = hf });

        public List<string> Compose(JobSettings job)
        {
            List<string> results = new List<string>();
            if (job.Validate())
            {
                List<Task> tasks = new List<Task>();

                // Create thread for each iteration and return results list when done filling.
                for (int i = 0; i < job.Iterations; i++)
                {
                    tasks.Add(Task.Run(() =>
                    {
                        string filled = FillPattern(job, i);
                        results.Add(filled);
                    }));
                }

                Task.WaitAll(tasks.ToArray());
            }
            return results;
        }

        private string FillPattern(JobSettings job, int currentIteration = 0)
        {
            List<IReference> references = job.Pattern.References;

            //Time to draw straws
            string[] data = new string[references.Count];

            for (int i = 0; i < references.Count; i++)
            {
                data[i] = references[i].Pull(e);
            }

            StringBuilder output = new StringBuilder(string.Join(Environment.NewLine, job.Pattern.Body));

            for (int i = 0; i < references.Count; i++)
            {
                output.Replace("[@" + i + "]", data[i]);
            }

            switch (CalcHF(job.HeaderAndFooter, currentIteration, job.Iterations))
            {
                case Pattern.HeaderAndFooterSetting.BOTH:
                    output.Insert(0, string.Join(Environment.NewLine, job.Pattern.Header));
                    output.Append(string.Join(Environment.NewLine, job.Pattern.Footer));
                    break;

                case Pattern.HeaderAndFooterSetting.HEADER_ONLY:
                    output.Insert(0, string.Join(Environment.NewLine, job.Pattern.Header));
                    break;

                case Pattern.HeaderAndFooterSetting.FOOTER_ONLY:
                    output.Append(string.Join(Environment.NewLine, job.Pattern.Footer));
                    break;

                default:
                    break;
            }

            return output.ToString();
        }

        internal static Pattern.HeaderAndFooterSetting CalcHF(HeaderAndFooterSetting setting, int currentIteration, int Iterations)
        {
            Pattern.HeaderAndFooterSetting hf;
            switch (setting)
            {
                case HeaderAndFooterSetting.ALL:
                    hf = Pattern.HeaderAndFooterSetting.BOTH;
                    break;

                case HeaderAndFooterSetting.FIRST_LAST:
                    if (currentIteration == 0 && Iterations > 1) hf = Pattern.HeaderAndFooterSetting.HEADER_ONLY; // First
                    else if (currentIteration == Iterations - 1 && Iterations > 1) hf = Pattern.HeaderAndFooterSetting.FOOTER_ONLY; // Last
                    else if (Iterations == 1) hf = Pattern.HeaderAndFooterSetting.BOTH; // Both because there is only one pattern
                    else hf = Pattern.HeaderAndFooterSetting.NONE; // Middle pattern, append neither
                    break;

                default:
                    hf = Pattern.HeaderAndFooterSetting.NONE;
                    break;
            }
            return hf;
        }
    }

    public class JobSettings
    {
        public Pattern Pattern;
        public int Iterations;
        public Composer.HeaderAndFooterSetting HeaderAndFooter;

        public JobSettings()
        {
            Pattern = new Pattern() { ID = -1 };
            Iterations = 1;
            HeaderAndFooter = Composer.HeaderAndFooterSetting.NONE;
        }

        public JobSettings(Pattern pattern, int iterations, Composer.HeaderAndFooterSetting headerAndFooterSetting)
        {
            Pattern = pattern;
            Iterations = iterations;
            HeaderAndFooter = headerAndFooterSetting;
        }

        public bool Validate()
        {
            return !(Iterations < 1 || Pattern.ID == -1);
        }
    }
}