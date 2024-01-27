public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        for (int i = 0; i < s.Length; i++)
        {
            if (s.IndexOf(s[i], i + 1) != t.IndexOf(t[i], i + 1))
            {
                return false;
            }
        }
        return true;
    }
}