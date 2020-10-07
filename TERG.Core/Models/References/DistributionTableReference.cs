using System.Collections.Generic;
using System.Linq;
using TERG.Core.Interfaces;

namespace TERG.Core.Models.References
{
    public class DistributionTableReference : IReference
    {
        public List<DistributionRow> Rows;

        public string Type
        {
            get
            {
                return "DTBL";
            }
        }

        public DistributionTableReference()
        {
            Rows = new List<DistributionRow>();
        }

        public string Pull(Engine e)
        {
            int roll = Engine.RNG.Next(1, 101);
            string output = null;
            foreach (var r in Rows)
            {
                if (roll >= r.Start && roll <= r.End)
                {
                    output = r.Value ?? r.Reference.Pull(e);
                }
            }
            return output ?? "DTBL ERROR";
        }
    }

    public class DistributionRow
    {
        public int Start = 1;
        public int End = 100;
        public string Value = "Empty";
        public IReference Reference = null;
    }
}