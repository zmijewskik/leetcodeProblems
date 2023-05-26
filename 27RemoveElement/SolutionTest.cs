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
        private readonly Solution _solution;

        public SolutionTest()
        {
            _solution = new Solution();
        }

        [Theory]
        [InlineData(new int[] { 3, 2, 2, 3 }, 3, 2)]
        [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5)]
        public void RemoveElement_ReturnsNumberOfNotRemovedElements(
            int[] input, int valueToRemove, int numbersLeft)
        {
            // Act
            var result = _solution.RemoveElement(input, valueToRemove);

            // Assert
            Assert.Equal(numbersLeft, result);
        }
    }
}
