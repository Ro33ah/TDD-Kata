using FizzBuzzCode;
using System.Collections.Generic;
using Xunit;

namespace FizzBuzzTests
{
    public class FizzBuzzTest
    {
        private readonly FizzBuzz _fizzBuzz;

        public FizzBuzzTest()
        {
            _fizzBuzz = new FizzBuzz();
        }
        [Fact]
        public void ReturnString_ShouldReturnIntegerAsString()
        {
            //Arrange
            List<string> expected  = new List<string> { "1", "2", "fizz", "4", "buzz" };
            //Act
            List<string> actual = (List<string>)_fizzBuzz.ReturnString(5);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
