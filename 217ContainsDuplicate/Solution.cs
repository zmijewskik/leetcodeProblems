using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _217ContainsDuplicate
{
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            // .Count gives < nums.Length when nums contains duplicates
            return new HashSet<int>(nums).Count < nums.Length;
        }
    }
}
