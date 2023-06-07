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
        private readonly Solution _solution;
        public SolutionTest()
        {
            _solution = new Solution();
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(121)]
        [InlineData(9889)]
        public void IsPalindrome_ShouldReturnTrueWhenNumberIsAPalindrome(int input)
        {
            // Act
            var result = _solution.IsPalindrome(input);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(1234)]
        [InlineData(-121)]
        public void IsPalindrome_ShouldReturnFalseWhenNumberIsNotAPalindrome(int input)
        {
            // Act
            var result = _solution.IsPalindrome(input);

            // Assert
            Assert.False(result);
        }
    }
}
