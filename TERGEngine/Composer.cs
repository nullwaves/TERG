namespace TERGEngine
{
    public class Composer
    {
        private Engine e;

        private Composer()
        { }

        internal Composer(Engine engine)
        {
            e = engine;
        }

        public Composer(JobSettings job)
        {
            
        }
    }

    public class JobSettings
    {
        public enum HeaderAndFooterSetting
        {
            ALL,
            FIRST_LAST,
            NONE
        }

        public Pattern Pattern;
        public int Iterations;
        public HeaderAndFooterSetting HeaderAndFooter;
    }
}
