using System.Linq;
using TERG.Core.Interfaces;

namespace TERG.Core.Models.References
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

        public PatternReference()
        {
            PatternID = -1;
        }

        public string Pull(Engine e)
        {
            var pattern = e.GetPatternByID(PatternID);
            return pattern != null ? e.Composer.Compose(pattern, 1, Composer.HeaderAndFooterSetting.NONE).First() : string.Empty;
        }
    }
}