using System;
using System.Text;

namespace TERGEngine.Reference
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

        public string Pull(Engine e)
        {
            Pattern p = e.FindPatternById(PatternID);
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
