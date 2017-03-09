using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSeed.DataProviders.Parameters
{
    class LastNameSeedRequestParameters : SeedRequestParamatersBase
    {
        public override SeedType SeedDataType { get { return SeedType.LastName; } }
    }
}
