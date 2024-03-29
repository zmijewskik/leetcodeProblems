﻿using Xunit;

namespace _217ContainsDuplicate
{
    public class SolutionTest
    {
        private readonly Solution _solution;
        public SolutionTest()
        {
            _solution = new Solution();
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 1 }, true)]
        [InlineData(new int[] { 1, 2, 3, 4 }, false)]
        [InlineData(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
        public void TestContainsDuplicates(int[] nums, bool expected)
        {
            // Act
            bool result = _solution.ContainsDuplicate(nums);

            // Assert
            Assert.Equal(result, expected);
        }
    }
}
