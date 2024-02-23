using System;

public class Solution
{
    public int GetMoneyAmount(int n)
    {
        // 2D array stores computed results for subproblems
        int[,] table = new int[n + 1, n + 1];

        return DP(table, 1, n);
    }

    int DP(int[,] t, int s, int e)
    {
        // base case
        if (s >= e) return 0;
        if (t[s, e] != 0) return t[s, e];

        int res = int.MaxValue;

        for (int x = s; x <= e; x++)
        {
            int tmp = x + Math.Max(DP(t, s, x - 1), DP(t, x + 1, e));
            res = Math.Min(res, tmp);
        }
        // memoization of DP 
        t[s, e] = res;

        return res;
    }
}