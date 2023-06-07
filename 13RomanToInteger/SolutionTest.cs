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

        [Theory]
        [InlineData(3, "III")]
        [InlineData(9, "IX")]
        [InlineData(1994, "MCMXCIV")]
        public void TestRomanToInt(
            int expected, string romanExample)
        {
            // Assert
            Assert.Equal(expected, _solution.RomanToInt(romanExample));
        }
    }
}
