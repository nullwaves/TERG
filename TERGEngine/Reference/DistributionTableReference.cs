using System.Collections.Generic;
using System.Linq;

namespace TERGEngine.Reference
{
    public class DistributionTableReference : IReference
    {
        public List<DistributionRow> Rows = new List<DistributionRow>();

        public string Type
        {
            get
            {
                return "DTBL";
            }
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

        public string ToString(Engine e)
        {
            return "DTBL r" + Rows.Count();
        }
    }
    public class DistributionRow
    {
        public int Start = 1;
        public int End = 100;
        public string Value = "Empty";
        public IReference Reference = null;
        public string ToString(Engine e) => $"{Start}-{End} " + (Value ?? Reference.Pull(e));
    }
}
