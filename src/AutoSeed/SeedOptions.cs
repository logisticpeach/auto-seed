using System;
using System.Collections.Generic;
using System.Text;
using AutoSeed.DataProviders;
using AutoSeed.DataProviders.DefaultProviders;

namespace AutoSeed
{
    public class SeedOptions : ISeedOptions
    {
        public INameDataProvider NameProvder { get; set; }

        public ITextDataProvider TextProvider { get; set; }

        public SeedOptions()
        {
            NameProvder = new DefaultNameDataProvider();
            TextProvider = new DefaultTextDataProvider();
        }
    }
}
