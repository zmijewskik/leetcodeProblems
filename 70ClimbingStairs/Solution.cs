using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70ClimbingStairs
{
    // Basically it's a fibonacci.
    public class Solution
    {
        public int ClimbStairs(int n)
        {
            int a = 1, b = 1;
            while (n-- > 0)
                a = (b += a) - a;
            return a;
        }
    }

    // public class Solution {
    //     public int ClimbStairs(int n) {
    //         if(n <= 0) return 0;
    //         if(n == 1) return 1;
    //         if(n == 2) return 2;

    //         int oneStepBefore = 2;
    //         int twoStepsBefore = 1;
    //         int allWays = 0;

    //         for(int i = 2; i < n; i++){
    //             allWays = oneStepBefore + twoStepsBefore;
    //             twoStepsBefore = oneStepBefore;
    //             oneStepBefore = allWays;
    //         }
    //         return allWays;
    //     }
    // }

    //public class Solution
    //{
    //    public int ClimbStairs(int n)
    //    {
    //        if (n == 1)
    //        {
    //            return 1;
    //        }
    //        int[] dp = new int[n + 1];
    //        dp[1] = 1;
    //        dp[2] = 2;
    //        for (int i = 3; i <= n; i++)
    //        {
    //            dp[i] = dp[i - 1] + dp[i - 2];
    //        }
    //        return dp[n];
    //    }
    //}

    //public class Solution
    //{
    //    public int ClimbStairs(int n)
    //    {
    //        if (n == 1)
    //        {
    //            return 1;
    //        }
    //        int first = 1;
    //        int second = 2;
    //        int output = second;
    //        for (int i = 3; i <= n; i++)
    //        {
    //            output = first + second;
    //            first = second;
    //            second = output;
    //        }
    //        return output;
    //    }
    //}
}
