﻿namespace _125ValidPalindrome
{
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            var clean = s.ToLower().Where(x => char.IsLetterOrDigit(x));
            return clean.Reverse().SequenceEqual(clean);
        }
    }
}
