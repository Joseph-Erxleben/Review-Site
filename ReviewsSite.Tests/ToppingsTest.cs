using System;
using Microsoft.AspNetCore.Mvc;
using ReviewsSite.Controllers;
using Xunit;

namespace ReviewsSite.Tests
{
    public class ToppingsTest
    {
        [Fact]
        public void Toppings_Index_Returns_A_View()
        {
            var sut = new ToppingsController();

            var result = sut.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
