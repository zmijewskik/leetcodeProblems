using Xunit;

namespace _1TwoSum
{
    public class SolutionTest
    {
        private readonly Solution _solution;

        public SolutionTest()
        {
            _solution = new Solution();
        }

        [Theory]
        [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
        [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 10, new[] { 3, 4 })]
        public void TestTwoSum(
            int[] nums, int target, int[] expected)
        {
            //Act
            int[] result = _solution.TwoSum(nums, target);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
