using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSeed.Metadata
{
    public class SeedDoubleAttribute : SeedAttribute
    {
        public double MinValue { get; set; }

        public double MaxValue { get; set; }
    }
}
