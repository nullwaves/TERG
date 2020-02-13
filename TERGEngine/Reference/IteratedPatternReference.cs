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
            int t = MinimumIterations;

            if (MinimumIterations != MaximumIterations)
            {
                t = Engine.RNG.Next(MinimumIterations, MaximumIterations + 1);
            }

            for (int i = 0; i < t; i++)
            {
                s.Append(p.Fill(e) + Environment.NewLine);
            }

            return s.ToString();
        }

        public string ToString(Engine e)
        {
            string s = "IPAT: m" + MinimumIterations;
            if(MinimumIterations != MaximumIterations)
            {
                s += " M" + MaximumIterations;
            }
            s += " " + e.FindPatternById(PatternID).Name;
            return s;
        }
    }
}
