namespace LeetCode_Solutions;

public partial class Solution {
    public void MoveZeroes(int[] nums) {
        var nonZero = 0;

        for (var i = 0; i < nums.Length; i++) {
            if (nums[i] != 0) {
                nums[nonZero] = nums[i];
                nonZero++;
            }
        }

        var countOfZeroes = nums.Length - nonZero;
        
        // Fill array 'nums' with 0 from index nonZero with countOfZeroes elements
        if (countOfZeroes > 0)
            Array.Fill(nums, 0, nonZero, countOfZeroes);
    }
}