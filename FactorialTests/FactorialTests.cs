using Xunit;
using FactorialService;
using System;

namespace FactorialTests
{
    public class FactorialServiceTests
    {
        private readonly FactorialService.FactorialService service; 

        public FactorialCalculatorTests()
        {
            calculator = new FactorialService.FactorialService(); 
        }

        [Fact]
        public void Calculate_ShouldReturnCorrectFactorial_ForPositiveNumber()
        {
            int number = 5;
            long expected = 120; 

            long actual = calculator.Calculate(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Calculate_ShouldReturnOne_ForZero()
        {
            int number = 0;
            long expected = 1; 

            long actual = calculator.Calculate(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Calculate_ShouldThrowArgumentException_ForNegativeNumber()
        {
            int number = -1;

            Assert.Throws<ArgumentException>(() => calculator.Calculate(number));
        }
    }
}