using System;
using System.Collections.Generic;
using TERGEngine.Reference;

namespace TERGEngine
{
    public static class ReferenceFactory
    {
        public static readonly Dictionary<string, Type> typeMap = new Dictionary<string, Type>()
        {
            {"POOL", typeof(PoolReference)},
            {"PATT", typeof(PatternReference)},
            {"IPAT", typeof(IteratedPatternReference)},
            {"RPAT", typeof(RandomPatternReference)},
            {"RINT", typeof(RandomIntegerReference)},
            {"DTBL", typeof(DistributionTableReference)}
        };

        public static IReference Create(string reftype)
        {
            if (typeMap.ContainsKey(reftype))
                return (IReference)Activator.CreateInstance(typeMap[reftype]);

            return null;
        }
    }
}