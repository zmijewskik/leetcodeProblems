using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _1491AverageSalaryExcludingTheMinimumAndMaximumSalary
{
    public class SolutionTest
    {
        private readonly Solution _solution;

        public SolutionTest()
        {
            _solution = new Solution();
        }

        [Theory]
        [InlineData(new int[] { 4000, 3000, 1000, 2000 }, 2500)]
        [InlineData(new int[] { 1000, 2000, 3000 }, 2000)]
        public void TestAverageSalary(
            int[] salaries, int averageSalary)
        {
            // Assert
            Assert.Equal(averageSalary, _solution.Average(salaries));
        }
    }
}
