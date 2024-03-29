﻿using System;
using System.Collections.Generic;
using TERG.Core.Interfaces;
using TERG.Core.Models.References;

namespace TERG.Core
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