using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace _27RemoveElement
{
    public class SolutionTest
    {
        [Theory]
        [InlineData(, true)]
        [InlineData("()[]{}", true)]
        public void RemoveElement_ReturnsNumberOfNotRemovedElements(
            int[] input, int val, int expected)
        {
            // Arrange
            ValidParentheses solution = new ValidParentheses();

            // Act
            bool result = solution.IsValid(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
