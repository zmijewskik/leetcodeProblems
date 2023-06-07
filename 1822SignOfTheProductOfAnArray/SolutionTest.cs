using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _1822SignOfTheProductOfAnArray
{
    public class SolutionTest
    {
        private readonly Solution _solution;
        public SolutionTest()
        {
            _solution = new Solution();
        }

        [Theory]
        [InlineData(new int[] { -1, -2, -3, -4, 3, 2, 1 }, 1)]
        [InlineData(new int[] { 1, 5, 0, 2, -3 }, 0)]
        [InlineData(new int[] { -1, 1, -1, 1, -1 }, -1)]
        public void TestArraySign(
            int[] array, int expected)
        {
            // Act
            var result = _solution.ArraySign(array);
            // Assert
            Assert.Equal(result, expected);
        }
    }
}
