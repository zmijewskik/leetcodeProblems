using System;

public class Solution
{
    public string ShortestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
            return "";

        string reversed = ReverseString(s);
        string combined = s + "#" + reversed;

        int[] prefixArray = CalculatePrefixArray(combined);

        int longestPalindromePrefixLength = prefixArray[prefixArray.Length - 1];
        string palindromeSuffix = s.Substring(longestPalindromePrefixLength);
        string reversedPalindromeSuffix = ReverseString(palindromeSuffix);

        return reversedPalindromeSuffix + s;
    }

    private string ReverseString(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    private int[] CalculatePrefixArray(string s)
    {
        int n = s.Length;
        int[] prefixArray = new int[n];
        int j = 0;

        for (int i = 1; i < n; i++)
        {
            while (j > 0 && s[i] != s[j])
            {
                j = prefixArray[j - 1];
            }

            if (s[i] == s[j])
            {
                j++;
            }

            prefixArray[i] = j;
        }

        return prefixArray;
    }
}