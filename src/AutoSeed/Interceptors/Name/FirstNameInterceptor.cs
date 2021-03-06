﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSeed.Interceptors.Name
{
    class FirstNameInterceptor : IPropertyValueInterceptor
    {
        private DataProviders.INameDataProvider _nameProvider;

        public SeedType TargetType => SeedType.FirstName;

        public FirstNameInterceptor(DataProviders.INameDataProvider provider)
        {
            _nameProvider = provider;
        }

        public object GenerateValue(SeedRequest request)
        {
            return _nameProvider.GetFirstName();
        }
    }
}
