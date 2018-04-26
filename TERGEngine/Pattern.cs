using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TERGEngine.Reference;

namespace TERGEngine
{
    public class Pattern
    {
        public int ID;
        public string Name;
        public string Desc;
        private IReference[] references;
        public string Base;

        internal IReference[] References
        {
            get
            {
                return references;
            }

            set
            {
                references = value;
            }
        }

        public Pattern(string name)
        {
            Name = name;
            Desc = String.Empty;
            References = new IReference[0];
            Base = String.Empty;
        }

        public string Fill(Engine e)
        {
            //Time to draw straws
            string[] data = new string[References.Length];

            for(int i = 0; i < References.Length; i++)
            {
                data[i] = References[i].Pull(e);
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
