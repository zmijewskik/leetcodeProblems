using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _13._Roman_to_Integer
{
    public class SolutionTest
    {
        [Fact]
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
    }
}
