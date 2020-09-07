using System;
using System.Collections.Generic;
using System.Text;
using TERGEngine.Reference;

namespace TERGEngine
{
    public class Pattern
    {
        public int ID;
        public string Name;
        public string Desc;
        public List<IReference> References;
        public string[] Header;
        public string[] Body;
        public string[] Footer;

        public Pattern(int i, string name)
        {
            ID = i;
            Name = name;
            Desc = String.Empty;
            References = new List<IReference>();
            Header = new string[0];
            Body = new string[] { "[@0]" };
            Footer = new string[0];
        }

        public string Fill(Engine e, bool HeadAndFoot = false)
        {
            //Time to draw straws
            string[] data = new string[References.Count];

            for (int i = 0; i < References.Count; i++)
            {
                data[i] = References[i].Pull(e);
            }

            StringBuilder output = new StringBuilder(String.Join(Environment.NewLine, Body));


            for (int i = 0; i < References.Count; i++)
            {
                output.Replace("[@" + i + "]", data[i]);
            }

            if(HeadAndFoot)
            {
                output.Insert(0, string.Join(Environment.NewLine, Header));
                output.Append(string.Join(Environment.NewLine, Footer));
            }

            return output.ToString();
        }
    }
}
