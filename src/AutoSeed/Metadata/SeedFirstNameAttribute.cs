using AutoSeed.DataProviders.Parameters;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSeed.Metadata
{
    public class SeedFirstNameAttribute : SeedNameAttribute
    {
        public SeedFirstNameAttribute() : base(NameType.FirstName) { }
    }
}
