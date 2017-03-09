using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSeed.DataProviders.Parameters
{
    internal class FirstNameSeedRequestParamaters : SeedRequestParamatersBase
    {
        public override SeedType SeedDataType { get { return SeedType.FirstName; } }
    }
}
