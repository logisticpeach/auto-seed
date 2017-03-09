using AutoSeed.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSeed.Tests.Models
{
    class CollectionTestModel : FlatTestModel
    {
        [SeedCollection(Count = 3)]
        public IList<FlatTestModel> Friends { get; set; }
    }
}
