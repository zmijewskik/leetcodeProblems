using System;
using System.Collections.Generic;

public class Solution
{
    public int MaxFrequencyElements(int[] nums)
    {
        var numsFrequencyDictionary = CreateFrequencyDictionary(nums);
        var maxFrequency = FindMaxFrequency(numsFrequencyDictionary);

        var result = 0;
        foreach (var item in numsFrequencyDictionary)
        {
            if (item.Value == maxFrequency) result += item.Value;
        }
        return result;
    }
    private Dictionary<int, int> CreateFrequencyDictionary(int[] nums)
    {
        var result = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!result.ContainsKey(nums[i]))
            {
                result.Add(nums[i], 0);
            }
            result[nums[i]]++;
        }
        return result;
    }
    private int FindMaxFrequency(Dictionary<int, int> dictionary)
    {
        var maxFrequency = 0;
        foreach (var item in dictionary)
        {
            maxFrequency = Math.Max(maxFrequency, item.Value);
        }
        return maxFrequency;
    }
}
