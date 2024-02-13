public class NumArray
{

    private int[] _nums;

    public NumArray(int[] nums)
    {
        var n = nums.Length;
        _nums = new int[n + 1];
        for (int i = 0; i < n; i++) _nums[i + 1] = _nums[i] + nums[i];
    }

    public int SumRange(int left, int right)
    {
        return _nums[right + 1] - _nums[left];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */