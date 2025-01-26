namespace LeetCode_Solutions;

public partial class Solution {
    public int[] TwoSumInputArrayIsSorted(int[] nums, int target)
    {
        var left = 0;                    // левая граница (начало массива)
        var right = nums.Length - 1;     // правая граница (конец массива)

        while (left < right) {
            var sum = nums[left] + nums[right];

            if (sum == target)
                return new int[] { left + 1, right + 1 };
            if (sum < target)
                left++;
            if (sum > target)
                right--;
        }

        return new int[2];
    }
}