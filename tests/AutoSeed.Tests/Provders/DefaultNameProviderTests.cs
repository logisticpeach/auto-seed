using System;
using System.Collections.Generic;
using System.Text;
using AutoSeed.DataProviders.DefaultProviders;
using Xunit;

namespace AutoSeed.Tests.Provders
{
    public class DefaultNameProviderTests
    {
        private DefaultNameDataProvider _nameProvider;

        public DefaultNameProviderTests()
        {
            _nameProvider = new DefaultNameDataProvider();
        }


        [Fact]
        public void test_first_name_generator()
        {
            string name = _nameProvider.GetFirstName();

            Assert.NotNull(name);

            Assert.NotEqual<string>(string.Empty, name);
        }

        [Fact]
        public void test_last_name_generator()
        {
            string name = _nameProvider.GetLastName();

            Assert.NotNull(name);

            Assert.NotEqual<string>(string.Empty, name);
        }
    }
}
