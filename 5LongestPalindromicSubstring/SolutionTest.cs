using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _5LongestPalindromicSubstring
{
    public class SolutionTest
    {
        private readonly Solution _solution;

        public SolutionTest()
        {
            _solution = new Solution();
        }

        [Theory]
        [InlineData("babad", "bab")]
        [InlineData("cbbd", "bb")]
        public void TestLengthOfLongestSubstring(
            string input, string longestPalindrome)
        {
            // Act
            var result = _solution.LongestPalindrome(input);

            // Assert
            Assert.Equal(result, longestPalindrome);
        }
    }
}
