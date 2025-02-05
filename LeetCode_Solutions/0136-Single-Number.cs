namespace LeetCode_Solutions;

public partial class Solution {
    public int SingleNumber(int[] nums) {
        var res = 0;

        for (var i = 0; i < nums.Length; i++)
            res ^= nums[i];

        return res;
    }
}