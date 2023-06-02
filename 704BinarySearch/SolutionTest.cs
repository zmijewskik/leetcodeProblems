using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _704BinarySearch
{
    public class SolutionTest
    {
        private readonly Solution _solution;

        public SolutionTest()
        {
            _solution = new Solution();
        }

        [Theory]
        [InlineData(new[] { -1, 0, 3, 5, 9, 12 }, 9, 4)]
        [InlineData(new[] { -1, 0, 3, 5, 9, 12 }, 2, -1)]
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
