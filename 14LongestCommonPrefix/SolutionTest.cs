using Xunit;

namespace _14LongestCommonPrefix
{
    public class SolutionTest
    {
        [Theory]
        [InlineData(new string[] { "flower", "flow", "flag" }, "fl")]
        [InlineData(new string[] { "dog", "racecar", "car" }, "")]
        public void LongestCommonPrefix_ReturnsLongestCommonPrefix(
            string[] strs, string prefix)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.LongestCommonPrefix(strs);

            // Assert
            Assert.Equal(result, prefix);
        }
    }
}
