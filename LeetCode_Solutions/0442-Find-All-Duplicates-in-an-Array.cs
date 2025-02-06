namespace LeetCode_Solutions;

public partial class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        var res = new List<int>();

        if (nums.Length == 0 || nums.Length == 1)
            return res;

        for (var i = 0; i < nums.Length; i++) {
            var index = Math.Abs(nums[i]) - 1;

            if (nums[index] < 0)
                res.Add(Math.Abs(nums[i]));

            nums[index] = -nums[index];
        }

        return res;
    }
}