using AutoSeed.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSeed.Tests.Models
{
    class SimpleRecursionTestModel : FlatTestModel
    {
        public FlatTestModel BestFriend { get; set; }
    }
}
