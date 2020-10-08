using TERG.Core.Interfaces;
using TERG.Core.Models.References;

namespace TERG.Core.Services
{
    public class ShorthandService
    {
        private readonly Engine engine;

        private ShorthandService()
        {
        }

        internal ShorthandService(Engine e)
        {
            engine = e;
        }

        public string PrettyReference(IReference reference)
        {
            string type = reference.Type;
            string retval = $"{type}: ";
            switch (type)
            {
                case "DTBL":
                    var dtbl = (DistributionTableReference)reference;
                    retval += $"r{dtbl.Rows}";
                    break;

                case "IPAT":
                    var ipat = (IteratedPatternReference)reference;
                    var pat = engine.GetPatternByID(ipat.PatternID);
                    retval += $"m{ipat.MinimumIterations}";
                    retval += ipat.Random ? $" M{ipat.MaximumIterations}" : string.Empty;
                    retval += pat != null ? pat.Name : "Empty";
                    break;

                case "PATT":
                    var patt = (PatternReference)reference;
                    retval += engine.GetPatternByID(patt.PatternID).Name;
                    break;

                case "POOL":
                    var pool = (PoolReference)reference;
                    retval += engine.GetPoolByID(pool.PoolID).Name;
                    break;

                case "RINT":
                    var rint = (RandomIntegerReference)reference;
                    retval += $"m{rint.Min} M{rint.Max} Z{rint.MinLength}";
                    break;

                case "RPAT":
                    var rpat = (RandomPatternReference)reference;
                    retval += $"c{rpat.PatternList.Count}";
                    break;
            }
            return retval;
        }

        public string PrettyDistributionRow(DistributionRow row)
        {
            return $"{row.Start}-{row.End} {row.Value ?? PrettyReference(row.Reference)}";
        }
    }
}