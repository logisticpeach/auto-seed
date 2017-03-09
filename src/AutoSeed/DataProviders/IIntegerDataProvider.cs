using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSeed.DataProviders
{
    public interface IIntegerDataProvider
    {
        int GetInteger(int min, int max);
    }
}
