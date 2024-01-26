using System.Collections.Generic;

public class Solution
{
    public bool IsHappy(int n)
    {
        HashSet<int> set = new();
        while (!set.Contains(n))
        {
            set.Add(n);
            if (n == 1)
            {
                return true;
            }
            n = SumOfDigitsSquare(n);
        }
        return false;
    }
    private int SumOfDigitsSquare(int n)
    {
        int sum = 0, currentDigit = 0;
        while (n > 0)
        {
            currentDigit = n % 10;
            n = n / 10;
            sum += currentDigit * currentDigit;
        }
        return sum;
    }
}