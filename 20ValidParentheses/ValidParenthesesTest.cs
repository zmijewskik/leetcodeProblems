using Xunit;

namespace _20ValidParentheses
{
    public class ValidParenthesesTest
    {
        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        public void TestValidParentheses(string input, bool expected)
        {
            // Arrange
            ValidParentheses solution = new ValidParentheses();

            // Act
            bool result = solution.IsValid(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}