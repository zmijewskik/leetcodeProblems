using System;

public class Solution
{
    public bool IsPowerOfThree(int n)
    {
        // int32 max 3 Pow is 19
        var maxPow = (int)Math.Pow(3, 19);

        return n > 0 && maxPow % n == 0;
    }
}