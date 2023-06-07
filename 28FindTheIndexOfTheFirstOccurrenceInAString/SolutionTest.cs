using Xunit;

namespace _28FindTheIndexOfTheFirstOccurrenceInAString
{
    public class SolutionTest
    {
        private readonly Solution _solution;

        public SolutionTest()
        {
            _solution = new Solution();
        }

        [Theory]
        [InlineData("sadbutsad", "sad", 0)]
        [InlineData("leetcode", "leeto", -1)]
        public void StrStr_ShouldReturnNeedlePosition(
            string haystack, string needle, int expected)
        {
            // Act
            var result = _solution.StrStr(haystack, needle);

            // Assert
            Assert.Equal(result, expected);
        }
    }
}