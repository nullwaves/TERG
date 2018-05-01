using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TERGEngine.Reference
{
    class PatternReference : IReference
    {
        public int PatternID;

        public string Pull(Engine e)
        {
            return e.FindPatternById(PatternID).Fill(e);
        }

        public string ToString(Engine e)
        {
            return "PATTERN: " + e.FindPatternById(PatternID);
        }
    }
}
