using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1822SignOfTheProductOfAnArray
{
    public class Solution
    {
        public int ArraySign(int[] nums)
        {
            int countNegativeNumbers = 0;
            foreach (int number in nums)
            {
                // Edge case x*0 always = 0
                if (number == 0) return 0;
                if (number < 0) countNegativeNumbers++;
            }
            return countNegativeNumbers % 2 == 0 ? 1 : -1;
        }
    }
}
