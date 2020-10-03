using System;
using System.Text;

namespace TERG.Core.Reference
{
    public class IteratedPatternReference : IReference
    {
        public int PatternID;
        public int MinimumIterations;
        public int MaximumIterations;

        public bool Random
        {
            get
            {
                return (MinimumIterations != MaximumIterations);
            }
        }

        public string Type
        {
            get
            {
                return "IPAT";
            }
        }

        public IteratedPatternReference()
        {
            PatternID = -1;
            MinimumIterations = 1;
            MaximumIterations = 1;
        }

        public string Pull(Engine e)
        {
            Pattern p = e.FindPatternById(PatternID);
            if (p == null)
            {
                return string.Empty;
            }

            StringBuilder s = new StringBuilder();
            int t = Random ? Engine.RNG.Next(MinimumIterations, MaximumIterations + 1) : MinimumIterations;

            for (int i = 0; i < t; i++)
            {
                s.Append(p.Fill(e) + Environment.NewLine);
            }

            return s.ToString();
        }

        public string ToString(Engine e)
        {
            var pat = e.FindPatternById(PatternID);
            return "IPAT: m" + MinimumIterations +
                (Random ? " M" + MaximumIterations : string.Empty) +
                " " + (pat != null ? pat.Name : "Empty");
        }
    }
}