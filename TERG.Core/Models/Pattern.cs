using System.Collections.Generic;
using TERG.Core.Interfaces;

namespace TERG.Core.Models
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

        public Pattern()
        {
            ID = -1;
            Name = string.Empty;
            Desc = string.Empty;
            References = new List<IReference>();
            Header = new string[0];
            Body = new string[0];
            Footer = new string[0];
        }
    }
}