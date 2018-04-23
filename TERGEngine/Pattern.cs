using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TERGEngine
{
    public class Pattern
    {
        public string Name;
        public string Desc;
        public string[] References;

        public Pattern(string name)
        {
            Name = name;
            Desc = String.Empty;
            References = new string[0];
        }
    }
}
