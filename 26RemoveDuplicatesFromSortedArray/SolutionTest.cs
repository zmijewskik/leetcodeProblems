using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _26RemoveDuplicatesFromSortedArray
{
    public class SolutionTest
    {
        private readonly Solution _solution;

        public SolutionTest()
        {
            _solution = new Solution();
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 2 }, 2, new int[] { 1, 2 })]
        [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5, new int[] { 0, 1, 2, 3, 4 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 5, new int[] { 1, 2, 3, 4, 5 })]
        public void TestRemoveDuplicates(int[] nums, int expectedLength, int[] expectedArray)
        {
            // Act
            int actualLength = _solution.RemoveDuplicates(nums);
            int[] actualArray = nums[..actualLength];

            // Assert
            Assert.Equal(expectedLength, actualLength);
            Assert.Equal(expectedArray, actualArray);
        }
    }
}
