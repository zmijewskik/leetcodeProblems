﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26RemoveDuplicatesFromSortedArray
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int insertIndex = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] != nums[i])
                {
                    nums[insertIndex] = nums[i];
                    insertIndex++;
                }
            }
            return insertIndex;
        }
    }
}
