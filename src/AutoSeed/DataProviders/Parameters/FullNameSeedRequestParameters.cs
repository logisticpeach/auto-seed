using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSeed.DataProviders.Parameters
{
    class FullNameSeedRequestParameters : SeedRequestParamatersBase
    {
        public override SeedType SeedDataType { get { return SeedType.FullName; } }
    }
}
