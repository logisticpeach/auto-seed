using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSeed.Metadata
{
    public class SeedIntegerAttribute : SeedAttribute
    {
        public int MinValue { get; set; }

        public int MaxValue { get; set; }

        public SeedIntegerAttribute() { }
    }
}
