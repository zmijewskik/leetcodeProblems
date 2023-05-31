using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _35SearchInsertPosition
{
    public class SolutionTest
    {
        private readonly Solution _solution;

        public SolutionTest()
        {
            _solution = new Solution();
        }

        [Theory]
        [InlineData(new[] { 1, 3, 5, 6 }, 5, 2)]
        [InlineData(new[] { 1, 3, 5, 6 }, 2, 1)]
        [InlineData(new[] { 1, 3, 5, 6 }, 7, 4)]
        public void TestSearchInsert(
            int[] nums, int target, int expected)
        {
            // Act
            var result = _solution.SearchInsert(nums, target);

            // Assert
            Assert.Equal(result, expected);
        }
    }
}
