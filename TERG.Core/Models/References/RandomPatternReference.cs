using System.Collections.Generic;
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
            Pattern p = e.FindPatternById(PatternList[Engine.RNG.Next(0, PatternList.Count)]);
            return p?.Fill(e);
        }

        public string ToString(Engine e)
        {
            return "RPAT: " + PatternList.Count + " patterns";
        }
    }
}