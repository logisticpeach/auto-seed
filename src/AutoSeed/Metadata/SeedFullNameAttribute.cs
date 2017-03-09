using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSeed.Metadata
{
    public class SeedFullNameAttribute : SeedNameAttribute
    {
        public SeedFullNameAttribute() : base(NameType.FullName) { }
    }
}
