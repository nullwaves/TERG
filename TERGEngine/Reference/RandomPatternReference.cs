using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TERGEngine.Reference
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

        public string Pull(Engine e)
        {
            Pattern p = e.FindPatternById(PatternList[Engine.RNG.Next(0, PatternList.Count)]);
            return p.Fill(e);
        }

        public string ToString(Engine e)
        {
            return "RPAT: " + PatternList.Count + " patterns";
        }
    }
}
