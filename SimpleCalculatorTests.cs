using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace xUnitTestProject
{
    public class SimpleCalculatorTests
    {
        [Fact]
        public void AddTest()
        {
            // Arrange
            var calculator = new SimpleCalculator();

            // Act
            var result = calculator.Add(2, 2);

            // Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void SubTest()
        {
            // Arrange
            var calculator = new SimpleCalculator();

            // Act
            var result = calculator.Sub(2, 2);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void MultTest() 
        {
            // Arrange
            var calculator = new SimpleCalculator();

            // Act
            var result = calculator.Mult(2, 2);

            // Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void DivTest()
        {
            // Arrange
            var calculator = new SimpleCalculator();

            // Act
            var result = calculator.Div(2, 2);

            // Assert
            Assert.Equal(1, result);
        }
    }
}
