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
            IGNORE_ALL,
            ONCE_PER_JOB,
            EVERY_PATTERN
        }

        public Pattern Pattern;
        public int Iterations;
        public HeaderAndFooterSetting HeaderAndFooter;
    }
}
