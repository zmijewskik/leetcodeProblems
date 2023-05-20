namespace _1TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
                for (int j = i + 1; j < nums.Length; j++)
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
            return new int[] { };
        }
    }

    public class Solution2
    {
        public int[] TwoSum2(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
                for (int j = 1 + 1; j < nums.Length; j++)
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
            return new int[] { };
        }
    }
}