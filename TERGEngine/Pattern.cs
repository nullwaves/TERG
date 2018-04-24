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
        public string Base;

        public Pattern(string name)
        {
            Name = name;
            Desc = String.Empty;
            References = new string[0];
            Base = String.Empty;
        }

        public string Fill(string[] data)
        {
            if(data.Length != References.Length)
            {
                return "Data payload does not match references.";
            }

            string output = Base;

            for(int i = 0; i < References.Length; i++)
            {
                output.Replace("[@" + i + "]", data[i]);
            }

            return output;
        }
    }
}
