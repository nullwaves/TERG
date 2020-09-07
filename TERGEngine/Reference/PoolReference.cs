namespace TERGEngine.Reference
{
    public class PoolReference : IReference
    {
        public string Type
        {
            get
            {
                return "POOL";
            }
        }

        public int PoolID;

        public PoolReference()
        {
            PoolID = -1;
        }

        public string Pull(Engine e)
        {
            return e.FindPoolById(PoolID)?.Pull(e);
        }

        public string ToString(Engine e)
        {
            return "POOL: " + e.FindPoolById(PoolID)?.Name;
        }
    }
}
