using System;
using System.Collections.Generic;
using System.Text;
using AutoSeed.DataProviders;

namespace AutoSeed
{
    public interface ISeedOptions
    {
        INameDataProvider NameProvder { get; }

        ITextDataProvider TextProvider { get; }
    }
}
