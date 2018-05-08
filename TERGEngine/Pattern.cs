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
        public List<IReference> References;
        public string[] Base;

        public Pattern(int i, string name)
        {
            ID = i;
            Name = name;
            Desc = String.Empty;
            References = new List<IReference>();
            Base = new string[0];
        }

        public string Fill(Engine e)
        {
            //Time to draw straws
            string[] data = new string[References.Count];

            for (int i = 0; i < References.Count; i++)
            {
                data[i] = References[i].Pull(e);
            }

            StringBuilder output = new StringBuilder(String.Join(Environment.NewLine, Base));
            /*
            foreach (string s in Base)
            {
                output.Append(s);
            }
            */


            for (int i = 0; i < References.Count; i++)
            {
                output.Replace("[@" + i + "]", data[i]);
            }

            return output.ToString();
        }
    }
}
