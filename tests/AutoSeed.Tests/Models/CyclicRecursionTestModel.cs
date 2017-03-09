using AutoSeed.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSeed.Tests.Models
{
    class CyclicRecursionTestModel
    {
        [SeedFirstName]
        public string Name { get; set; }

        public CyclicRecursionTestModel Child { get; set; }
    }
}
