using Xunit;

namespace _20ValidParentheses
{
    public class SolutionTest
    {
        private readonly Solution _solution;
        public SolutionTest()
        {
            _solution = new Solution();
        }

        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        public void TestValidParentheses(
            string input, bool expected)
        {
            // Act
            bool result = _solution.IsValid(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}