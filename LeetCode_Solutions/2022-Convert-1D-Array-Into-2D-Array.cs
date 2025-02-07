namespace LeetCode_Solutions;

public partial class Solution {
    public int[][] Construct2DArray_WithTwoLoops(int[] original, int m, int n) {
        var ans = new int[m][];

        if (m * n != original.Length)
            return [];

        for (var i = 0; i < m; i++) {
            ans[i] = new int[n];

            for (var j = 0; j < n; j++) {
                ans[i][j] = original[n * i + j];
            }
        }

        return ans;
    }
}