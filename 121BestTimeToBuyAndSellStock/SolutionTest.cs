using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _121BestTimeToBuyAndSellStock
{
    public class SolutionTest
    {
        private readonly Solution _solution;

        public SolutionTest()
        {
            _solution = new Solution();
        }

        [Theory]
        [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
        [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
        public void TestMaxProfit(
            int[] prices, int maxProfit)
        {
            // Assert
            Assert.Equal(maxProfit, _solution.MaxProfit(prices));
        }
    }
}
