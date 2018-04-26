using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TERGEngine.Reference
{
    // find a way to add global variables for reference types.
    interface IReference
    {

        int Type
        string Pull(Engine e);
    }
}
