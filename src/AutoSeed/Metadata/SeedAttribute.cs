using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSeed.Metadata
{
    public abstract class SeedAttribute : Attribute
    {
        public abstract SeedType SeedDataType { get; }

        internal abstract SeedRequestParamatersBase GetParameters();
    }
}
