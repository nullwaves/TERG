using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TERGEngine.Reference
{
    class PoolReference : IReference
    {
        public int PoolID;
        
        public string Pull(Engine e)
        {
            return e.FindPoolById(PoolID).Pull();
        }
    }
}
