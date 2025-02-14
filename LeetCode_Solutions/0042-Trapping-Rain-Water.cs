namespace LeetCode_Solutions;

public partial class Solution {
    private int totalArea;
    private bool hasNewMax = false;

    public int Trap(int[] nums) {
        var left = 0;
        var right = left + 1;

        while (right < nums.Length - 1) {
            if (nums[left] == 0) {
                left++;
                right = left + 1;
                continue;
            }

            var nextMax = 0;
            var nextMaxIndex = 0;

            while (nums[left] > nums[right]) {
                if (nums[right] >= nextMax) {
                    nextMax = nums[right];
                    nextMaxIndex = right;
                }

                if (right == nums.Length - 1) {
                    if (nums[0] == nums.Length && 
                        nums[1] == nums.Length - 1 &&
                        nums[nums.Length - 1] == 1) {
                        return 0;
                    }

                    if (nums[left] > nextMax) {
                        nums[left] = nextMax;
                        right = nextMaxIndex;

                        AddArea(nums, left, right);
                        hasNewMax = true;

                        continue;
                    }
                }

                right++;
            }

            if (!hasNewMax)
                AddArea(nums, left, right);

            left = right;
            right = left + 1;
        }

        return totalArea;
    }

    private int AddArea(int[] nums, int left, int right) {
        for (var i = left + 1; i <= right - 1; i++) {
            var area = Math.Min(nums[left], nums[right]) - nums[i];

            if (area <= 0)
                continue;

            totalArea += area;
        }

        return totalArea;
    }
}