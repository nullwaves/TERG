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
            return e.GetPatternByID(PatternID)?.Fill(e);
        }
    }
}