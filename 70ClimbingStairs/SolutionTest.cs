using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _70ClimbingStairs
{
    public class SolutionTest
    {
        private readonly Solution _solution;

        public SolutionTest()
        {
            _solution = new Solution();
        }

        [Theory]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(5, 8)]
        public void TestSearchInsert(
            int nrOfStairs, int nrOfWays)
        {
            // Act
            var result = _solution.ClimbStairs(nrOfStairs);

            // Assert
            Assert.Equal(result, nrOfWays);
        }
    }
}
