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
        public IReference[] References;
        public string[] Base;

        public Pattern(string name)
        {
            Name = name;
            Desc = String.Empty;
            References = new IReference[0];
            Base = new string[0];
        }

        public string Fill(Engine e)
        {
            //Time to draw straws
            string[] data = new string[References.Length];

            for(int i = 0; i < References.Length; i++)
            {
                data[i] = References[i].Pull(e);
            }

            string output = Base.ToString();

            for(int i = 0; i < References.Length; i++)
            {
                output.Replace("[@" + i + "]", data[i]);
            }

            return output;
        }
    }
}
