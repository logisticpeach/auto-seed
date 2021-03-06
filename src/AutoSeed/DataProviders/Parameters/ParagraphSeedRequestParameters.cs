﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSeed.DataProviders.Parameters
{
    class ParagraphSeedRequestParameters : SeedRequestParamatersBase
    {
        public override SeedType SeedDataType { get { return SeedType.TextWithParagraphCount; } }

        public int ParagraphCount { get; set; }
    }
}
