using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSeed.DataProviders
{
    public interface INameDataProvider
    {
        string GetFirstName();

        string GetLastName();
    }
}
