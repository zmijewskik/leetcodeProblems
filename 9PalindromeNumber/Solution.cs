namespace _9PalindromeNumber
{
    public class Solution
    {
        //public bool IsPalindrome(int x)
        //{
        //    if (x < 0 || (x % 10 == 0 && x != 0))
        //    {
        //        return false;
        //    }

        //    int revertedNumber = 0;
        //    while (x > revertedNumber)
        //    {
        //        revertedNumber = revertedNumber * 10 + x % 10;
        //        x /= 10;
        //    }

        //    return x == revertedNumber || x == revertedNumber / 10;
        //}

        // solution with converting to string > char and reversing

        //public bool IsPalindrome(int x)
        //{
        //    var y = x.ToString().ToCharArray();
        //    Array.Reverse(y);
        //    return x.ToString() == new string(y);
        //}

        // solution with converting to string and reversing using LINQ

        public bool IsPalindrome(int x)
        {
            var reverseString = x.ToString().Reverse();
            if (string.Concat(reverseString) != x.ToString())
                return false;
            return true;
        }
    }
}
