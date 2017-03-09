using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSeed
{
    interface IPropertyValueInterceptor
    {
        object GenerateValue(SeedRequest request);

        SeedType TargetType { get; }
    }
}
