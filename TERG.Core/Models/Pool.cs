namespace TERG.Core.Models
{
    public class Pool
    {
        public int ID;
        public int ParentID;
        public string Name;
        public string[] List;

        public Pool()
        {
            ID = -1;
            Name = string.Empty;
            ParentID = -1;
            List = new string[0];
        }
    }
}