using System.Collections.Generic;
using System.Linq;

namespace TERG.Core.Models
{
    public class Pool
    {
        public int ID;
        public int ParentID;
        public string Name;
        public string[] List;

        public Pool(int i, string n)
        {
            ID = i;
            Name = n;
            ParentID = -1;
            List = new string[0];
        }

        public string Pull(Engine e)
        {
            // Fetch any children
            List<string> full = List.ToList();
            var children = e.Pools.Where(c => c.ParentID == ID);
            foreach (Pool p in children)
            {
                full.AddRange(p.List);
            }

            return full[Engine.RNG.Next(0, full.Count)];
        }
    }
}