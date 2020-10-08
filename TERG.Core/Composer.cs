using System.Collections.Generic;
using System.Threading.Tasks;
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
                        var hf = CalcHF(job.HeaderAndFooter, i, job.Iterations);
                        string filled = job.Pattern.Fill(e, hf);
                        results.Add(filled);
                    }));
                }

                Task.WaitAll(tasks.ToArray());
            }
            return results;
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