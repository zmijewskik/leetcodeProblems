using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _217ContainsDuplicate
{
    // public class Solution {
    //     public bool ContainsDuplicate(int[] nums) {
    //         return nums.GroupBy(x => x).Count() != nums.Length;
    //     }
    // }

    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);

            if (set.Count < nums.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
