using Xunit;

namespace _13RomanToInteger
{
    public class SolutionTest
    {
        private readonly Solution _solution;

        public SolutionTest()
        {
            _solution = new Solution();
        }

        [Fact(Skip = "Old implementation")]
        public void TestRomanToInt()
        {
            // Arrange
            Solution solution = new Solution();
            string s1 = "III";
            string s2 = "IX";
            string s3 = "MCMXCIV";

            // Act
            int result1 = solution.RomanToInt(s1);
            int result2 = solution.RomanToInt(s2);
            int result3 = solution.RomanToInt(s3);

            // Assert
            Assert.Equal(3, result1);
            Assert.Equal(9, result2);
            Assert.Equal(1994, result3);
        }

        [Theory]
        [InlineData(3, "III")]
        [InlineData(9, "IX")]
        [InlineData(1994, "MCMXCIV")]
        public void TestRomanToIntTheory(
            int expected, string s1)
        {
            Assert.Equal(expected, _solution.RomanToInt(s1));
        }
    }
}
