namespace TERG.Core.Models.References
{
    public class PoolReference : BaseReference
    {
        public new string Type
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

        public override string Pull(Engine e)
        {
            return e.PoolManager.Pull(PoolID);
        }
    }
}