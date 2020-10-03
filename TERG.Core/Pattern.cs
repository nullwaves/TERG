using System;
using System.Collections.Generic;
using System.Text;
using TERG.Core.Reference;

namespace TERG.Core
{
    public class Pattern
    {
        public enum HeaderAndFooterSetting
        {
            NONE,
            BOTH,
            HEADER_ONLY,
            FOOTER_ONLY
        }

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

        public string Fill(Engine e, HeaderAndFooterSetting HeadAndFoot = HeaderAndFooterSetting.NONE)
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

            switch (HeadAndFoot)
            {
                case HeaderAndFooterSetting.BOTH:
                    output.Insert(0, string.Join(Environment.NewLine, Header));
                    output.Append(string.Join(Environment.NewLine, Footer));
                    break;

                case HeaderAndFooterSetting.HEADER_ONLY:
                    output.Insert(0, string.Join(Environment.NewLine, Header));
                    break;

                case HeaderAndFooterSetting.FOOTER_ONLY:
                    output.Append(string.Join(Environment.NewLine, Footer));
                    break;

                default:
                    break;
            }

            return output.ToString();
        }
    }
}