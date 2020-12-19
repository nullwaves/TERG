using System;
using System.Text;

namespace TERG.Core.Models.References
{
    public class IteratedPatternReference : BaseReference
    {
        public int PatternID;
        public int MinimumIterations;
        public int MaximumIterations;

        public bool Random
        {
            get
            {
                return MinimumIterations != MaximumIterations;
            }
        }

        public override string Type
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

        public override string Pull(Engine e)
        {
            Pattern p = e.GetPatternByID(PatternID);
            if (p == null)
            {
                return string.Empty;
            }

            StringBuilder s = new StringBuilder();
            int t = Random ? Engine.RNG.Next(MinimumIterations, MaximumIterations + 1) : MinimumIterations;

            for (int i = 0; i < t; i++)
            {
                s.Append(e.Composer.Compose(p, 1, Composer.HeaderAndFooterSetting.NONE) + Environment.NewLine);
            }

            return s.ToString();
        }
    }
}