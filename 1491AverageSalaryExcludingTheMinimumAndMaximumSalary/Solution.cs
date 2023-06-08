using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1491AverageSalaryExcludingTheMinimumAndMaximumSalary
{
    public class Solution
    {
        public double Average(int[] salaries)
        {
            int minSalary = int.MaxValue;
            int maxSalary = int.MinValue;
            int sum = 0;

            foreach (int salary in salaries)
            {
                sum += salary;
                minSalary = Math.Min(minSalary, salary);
                maxSalary = Math.Max(maxSalary, salary);
            }
            return (double)(sum - minSalary - maxSalary) / (double)(salaries.Length - 2);
        }
    }
}
