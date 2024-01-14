namespace LeetCode_Solutions;

public partial class Solution {

    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int x = target - nums[i];

            if (dict.ContainsKey(x))
                return new int[] { dict[x], i };

            if (!dict.ContainsKey(nums[i]))
                dict[nums[i]] = i;
        }

        return null;
    }
}