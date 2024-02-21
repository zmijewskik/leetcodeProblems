public class Solution
{
    public bool IsPowerOfFour(int n)
    {
        return (n & 0xaaaaaaaa) == 0 && (BitOperations.PopCount((uint)n) == 1);
    }
}