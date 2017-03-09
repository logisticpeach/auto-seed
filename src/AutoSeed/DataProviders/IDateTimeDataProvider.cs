using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSeed.DataProviders
{
    public interface IDateTimeDataProvider
    {
        DateTimeOffset GetDate(DateTimeOffset min, DateTimeOffset max);
    }
}
