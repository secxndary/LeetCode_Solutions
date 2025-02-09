namespace LeetCode_Solutions;

public partial class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        var n = nums.Length;
        var ans = new List<int>();

        for (var i = 0; i < n; i++) {
            var index = Math.Abs(nums[i]) - 1;

            if (nums[index] > 0)
                nums[index] = -nums[index];
        }

        for (var i = 0; i < n; i++) {
            if (nums[i] > 0)
                ans.Add(i + 1);
        }

        return ans;
    }
}