using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TERGEngine
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
            ParentID = 0;
            List = new string[0];
        }

        public string Pull()
        {
            return List[new Random().Next(0, List.Length)];
        }
    }
}
