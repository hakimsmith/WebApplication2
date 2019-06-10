using System;
using Xunit;
using WebApplication2.Controllers;

namespace WebApplication2.Tests
{
    class SecondController
    {
	[Fact]
	public void Index_Returns_Funky_Skunky()
        {
            var underTest = new SecondController();
            var result = underTest();
            Assert.Equal("Funky Skunk", result);
        }


    }
}
