using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _66PlusOne
{
    public class SolutionTest
    {
        private readonly Solution _solution;

        public SolutionTest()
        {
            _solution = new Solution();
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 4 })]
        [InlineData(new[] { 4, 3, 2, 1 }, new[] { 4, 3, 2, 2 })]
        [InlineData(new[] { 9, 9 }, new[] { 1, 0, 0 })]
        [InlineData(new[] { 9 }, new[] { 1, 0 })]
        public void TestSearchInsert(
            int[] digits, int[] expected)
        {
            // Act
            var result = _solution.PlusOne(digits);

            // Assert
            Assert.Equal(result, expected);
        }
    }
}
