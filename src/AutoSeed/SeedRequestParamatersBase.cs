using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSeed
{
    internal abstract class SeedRequestParamatersBase
    {
        public abstract SeedType SeedDataType { get; }
    }
}
