using System.Collections.Generic;
using System.Linq;

namespace TERG.Core.Models.References
{
    public class RandomPatternReference : BaseReference
    {
        public List<int> PatternList;

        public override string Type
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

        public override string Pull(Engine e)
        {
            if (PatternList.Count < 1) return string.Empty;
            Pattern p = e.GetPatternByID(PatternList[Engine.RNG.Next(0, PatternList.Count)]);
            return p != null ? e.Composer.Compose(p, 1, Composer.HeaderAndFooterSetting.NONE).First() : string.Empty;
        }
    }
}