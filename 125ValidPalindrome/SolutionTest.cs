using Xunit;

namespace _125ValidPalindrome
{
    public class SolutionTest
    {
        private readonly Solution _solution;
        public SolutionTest()
        {
            _solution = new Solution();
        }

        [Theory]
        [InlineData("A man, a plan, a canal: Panama", true)]
        [InlineData("race a car", false)]
        [InlineData(" ", true)]
        public void TestContainsDuplicates(string s, bool expected)
        {
            // Act
            bool result = _solution.IsPalindrome(s);

            // Assert
            Assert.Equal(result, expected);
        }
    }
}
