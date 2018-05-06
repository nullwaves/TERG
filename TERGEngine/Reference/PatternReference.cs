using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TERGEngine.Reference
{
    public class PatternReference : IReference
    {
        public string Type
        {
            get
            {
                return "PATT";
            }
        }

        public int PatternID;

        public string Pull(Engine e)
        {
            return e.FindPatternById(PatternID).Fill(e);
        }

        public string ToString(Engine e)
        {
            return "PATTERN: " + e.FindPatternById(PatternID).Name;
        }
    }
}
