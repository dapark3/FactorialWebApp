using Xunit;
using FactorialService;
using System;

namespace FactorialTests
{
    public class FactorialServiceTests
    {
        private readonly FactorialService.FactorialService service; 

        public FactorialServiceTests()
        {
            calculator = new FactorialService.FactorialService(); 
        }

        [Fact]
        public void Calculate_ReturnCorrectFactorial_ForPositiveNumber()
        {
            int number = 5;
            long expected = 120; 

            long actual = calculator.Calculate(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Calculate_ReturnOne_ForZero()
        {
            int number = 0;
            long expected = 1; 

            long actual = calculator.Calculate(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Calculate_ThrowArgumentException_ForNegativeNumber()
        {
            int number = -1;

            Assert.Throws<ArgumentException>(() => calculator.Calculate(number));
        }
    }
}