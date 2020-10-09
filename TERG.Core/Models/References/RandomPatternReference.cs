using System.Collections.Generic;
using System.Linq;
using TERG.Core.Interfaces;

namespace TERG.Core.Models.References
{
    public class RandomPatternReference : IReference
    {
        public List<int> PatternList;

        public string Type
        {
            get
            {
                return "RPAT";
            }
        }

        public RandomPatternReference()
        {
            PatternList = new List<int>();
        }

        public string Pull(Engine e)
        {
            if (PatternList.Count < 1) return string.Empty;
            Pattern p = e.GetPatternByID(PatternList[Engine.RNG.Next(0, PatternList.Count)]);
            return p != null ? e.Composer.Compose(p, 1, Composer.HeaderAndFooterSetting.NONE).First() : string.Empty;
        }
    }
}