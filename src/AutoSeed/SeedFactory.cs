﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSeed
{
    public class SeedFactory
    {
        public T SeedInstance<T>(T item)
        {
            return item;
        }
    }
}
