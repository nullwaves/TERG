using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
        public string Pull(Engine e)
        {
            return e.FindPoolById(PoolID).Pull();
        }

        public string ToString(Engine e)
        {
            return "POOL: " + e.FindPoolById(PoolID).Name;
        }
    }
}
