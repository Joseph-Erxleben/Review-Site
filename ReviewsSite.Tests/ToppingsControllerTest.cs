using System;
using Microsoft.AspNetCore.Mvc;
using ReviewsSite.Controllers;
using ReviewsSite.Models;
using Xunit;

namespace ReviewsSite.Tests
{
    public class ToppingsControllerTest
    {
        ToppingsController sut;
        
        public ToppingsControllerTest()
        {
            //sut = new ToppingsController();
        }


        [Fact]
        public void Toppings_Index_Returns_A_View()
        {
    
            var result = sut.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Toppings_Index_Returns_Toppings_Model()
        {
            var result = sut.Index();

            Assert.IsType<Toppings>(result.Model);
        }
    }
}
