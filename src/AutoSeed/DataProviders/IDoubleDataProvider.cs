using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSeed.DataProviders
{
    public interface IDoubleDataProvider
    {
        double GetDouble(double min, double max);
    }
}
