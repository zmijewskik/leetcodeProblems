using System.Collections.Generic;
using System.Linq;
using System;

Solution solution = new Solution();
bool result = solution.WordPattern("abba", "dog cat cat dog");

public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        var dict1 = new Dictionary<char, string>();
        var dict2 = new Dictionary<string, char>();
        var sList = s.Split(' ', StringSplitOptions.None);

        if (pattern.Length != sList.Count()) return false;

        for (int i = 0; i < sList.Count(); i++)
        {
            dict1.TryAdd(pattern[i], sList[i]);
            dict2.TryAdd(sList[i], pattern[i]);
            if (dict1[pattern[i]] != sList[i]) return false;
            if (dict2[sList[i]] != pattern[i]) return false;
        }

        return true;
    }
}