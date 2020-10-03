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

        public PatternReference()
        {
            PatternID = -1;
        }

        public string Pull(Engine e)
        {
            return e.FindPatternById(PatternID)?.Fill(e);
        }

        public string ToString(Engine e)
        {
            return "PATTERN: " + e.FindPatternById(PatternID)?.Name;
        }
    }
}