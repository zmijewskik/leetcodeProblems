using System.Linq;

public class Solution
{
    public int[] FindErrorNums(int[] nums)
    {
        int first = nums.GroupBy(x => x).Where(g => g.Count() == 2).Select(x => x.Key).First();
        int second = Enumerable.Range(1, nums.Length).Except(nums).First();

        return new int[] { first, second };
    }
}

//GroupBy and Where Clauses:

//nums.GroupBy(x => x): This groups the array nums by each unique element.
//Where(g => g.Count() == 2): This filters the groups to find those that have exactly two elements, indicating the repeated number.

//Select and First Operations:

//Select(x => x.Key): This selects the key (the repeated number) from the grouped elements.
//First(): This retrieves the first (and only) element from the selected keys, assigning it to the variable first.

//Enumerable.Range and Except:

//Enumerable.Range(1, nums.Length): This generates a sequence of numbers from 1 to the length of the nums array.
//Except(nums): This returns the set difference between the generated sequence and the elements in nums, giving the missing number.