using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSeed.Metadata
{
    public abstract class SeedNameAttribute : SeedAttribute
    {
        public NameType Type { get; set; }

        public override SeedType SeedDataType
        {
            get
            {
                switch (Type)
                {
                    case NameType.FirstName:
                        return SeedType.FirstName;
                    case NameType.LastName:
                        return SeedType.LastName;
                    default:
                        return SeedType.FullName;
                }
            }
        }

        internal override SeedRequestParamatersBase GetParameters()
        {
            switch (Type)
            {
                case NameType.FirstName:
                    return new AutoSeed.DataProviders.Parameters.FirstNameSeedRequestParamaters();
                case NameType.LastName:
                    return new AutoSeed.DataProviders.Parameters.LastNameSeedRequestParameters();
                default:
                    return new AutoSeed.DataProviders.Parameters.FullNameSeedRequestParameters();
            }
        }

        public SeedNameAttribute()
        {
            Type = NameType.FullName;
        }

        public SeedNameAttribute(NameType type)
        {
            Type = type;
        }

        public enum NameType
        {
            FirstName,
            LastName,
            FullName
        }
    }
}
