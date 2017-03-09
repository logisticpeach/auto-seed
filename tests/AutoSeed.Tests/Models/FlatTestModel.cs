using AutoSeed.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSeed.Tests.Models
{
    class FlatTestModel
    {
        [SeedFirstName]
        public string FirstName { get; set; }

        [SeedLastName]
        public string LastName { get; set; }

        [SeedFullName]
        public string FullName { get; set; }
    }
}
