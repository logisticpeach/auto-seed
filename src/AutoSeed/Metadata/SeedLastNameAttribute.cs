using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSeed.Metadata
{
    public class SeedLastNameAttribute : SeedNameAttribute
    {
        public SeedLastNameAttribute() : base(NameType.LastName) { }
    }
}
