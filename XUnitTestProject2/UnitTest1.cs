using System;
using Xunit;

namespace XUnitTestProject2
{
    public class HomeController
    {
        [Fact]
        public void Index_Returrns_Hello_World()
        {
            var underTest = new HomeController();

            var result = underTest.Index();

            Assert.Equal("Hello world!", result);

        }
    }
}
