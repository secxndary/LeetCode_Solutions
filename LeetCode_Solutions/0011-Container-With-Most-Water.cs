namespace LeetCode_Solutions;

public partial class Solution {
    public int MaxArea(int[] nums) {
        var left = 0;
        var right = nums.Length - 1;

        var width = nums.Length;
        var maxArea = 0;
        var area = 0;

        while (left < right) {
            width = right - left;
            area = Math.Min(nums[left], nums[right]) * width;

            if (nums[left] > nums[right])
                right--;
            else
                left++;

            if (area > maxArea) {
                maxArea = area;
            }
        }

        return maxArea;
    }
}