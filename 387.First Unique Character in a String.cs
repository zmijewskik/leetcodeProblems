﻿using System.Collections.Generic;

public class Solution
{
    public int FirstUniqChar(string s)
    {
        int n = s.Length;
        if (n == 0)
        {
            return -1;
        }

        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char ch in s)
        {
            if (charCount.ContainsKey(ch))
            {
                charCount[ch]++;
            }
            else
            {
                charCount[ch] = 1;
            }
        }

        for (int i = 0; i < n; i++)
        {
            if (charCount[s[i]] == 1)
            {
                return i;
            }
        }

        return -1;
    }
}