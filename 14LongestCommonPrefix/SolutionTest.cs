using Xunit;

namespace _14LongestCommonPrefix
{
    public class SolutionTest
    {
        private readonly Solution _solution;
        public SolutionTest()
        {
            _solution = new Solution();
        }

        [Theory]
        [InlineData(new string[] { "flower", "flow", "flag" }, "fl")]
        [InlineData(new string[] { "dog", "racecar", "car" }, "")]
        public void LongestCommonPrefix_ReturnsLongestCommonPrefix(
            string[] strs, string prefix)
        {
            // Act
            var result = _solution.LongestCommonPrefix(strs);

            // Assert
            Assert.Equal(result, prefix);
        }
    }
}
