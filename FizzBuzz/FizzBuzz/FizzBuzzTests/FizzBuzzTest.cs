using System;
using Xunit;
using FizzBuzz;

namespace FizzBuzzTests
{
    public class FizzBuzzTest
    {
        [Fact]
        public void ReturnString_ShouldReturnIntegerAsString()
        {
            //Arrange
            string[] expected = new string[] { "One" };
            //Act
            string[] actual = FizzBuzz.FizzBuzz.ReturnString(1);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
