using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ReviewsSite.Models;

namespace ReviewsSite.Tests
{
    public class ToppingsTests
    {
        Toppings sut;

        public ToppingsTests()
        {
            sut = new Toppings(17, "This is a name", "This is a description", true);
        }

        [Fact]
        public void Toppings_Constructer_Sets_ID_on_Toppings_Model()
        {
            int result = sut.Id;

            Assert.Equal(17, result);
        }

        [Fact]
        public void Toppings_Constructer_Sets_Name_On_Toppings_Model()
        {
            string result = sut.Name;

            Assert.Equal("This is a name", result);
        }

        [Fact]
        public void Toppings_Constructer_Sets_Description_On_Toppings_Model()
        {
            string result = sut.Description;

            Assert.Equal("This is a description", result);
        }

        [Fact]
        public void Toppings_Constructer_Sets_IsVegetarian_On_Toppings_Model()
        {
            bool result = sut.IsVegetarian;

            Assert.True(result);
        }
    }
}
