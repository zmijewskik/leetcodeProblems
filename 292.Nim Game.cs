﻿public class Solution
{
    public bool CanWinNim(int n)
    {
        if (n % 4 != 0)
        {
            return true;
        }
        return false;
    }
}