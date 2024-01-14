namespace LeetCode_Solutions;

public partial class Solution {
    public bool ContainsDuplicate(int[] nums) {
        return nums.Length > nums.ToHashSet().Count;
    }
}