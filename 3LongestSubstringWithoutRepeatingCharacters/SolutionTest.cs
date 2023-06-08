using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _3LongestSubstringWithoutRepeatingCharacters
{
    public class SolutionTest
    {
        private readonly Solution _solution;

        public SolutionTest()
        {
            _solution = new Solution();
        }

        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        public void TestLengthOfLongestSubstring(
            string input, int count)
        {
            // Act
            var result = _solution.LengthOfLongestSubstring(input);

            // Assert
            Assert.Equal(result, count);
        }
    }
}
