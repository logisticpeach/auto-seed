using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSeed.Metadata
{
    public class SeedDateAttribute : SeedAttribute
    {
        public DateTimeOffset EarliestDate { get; set; }

        public DateTimeOffset LatestDate { get; set; }

        public SeedDateAttribute() { }
    }
}
