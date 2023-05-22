using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _9PalindromeNumber
{
    public class SolutionTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(121)]
        [InlineData(9889)]
        public void PalindromeNumber_ShouldReturnTrueWhenNumberIsAPalindrome(int input)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.IsPalindrome(input);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(1234)]
        [InlineData(-121)]
        public void PalindromeNumber_ShouldReturnFalseWhenNumberIsNotAPalindrome(int input)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.IsPalindrome(input);

            // Assert
            Assert.False(result);
        }
    }
}
