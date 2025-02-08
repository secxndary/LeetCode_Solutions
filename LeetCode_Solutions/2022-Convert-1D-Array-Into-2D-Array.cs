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
    
    public int[][] Construct2DArray_WithArrayCopy(int[] original, int m, int n) {
        var ans = new int[m][];

        if (m * n != original.Length)
            return [];

        for (var i = 0; i < m; i++) {
            ans[i] = new int[n];
            // 1st - source array
            // 2nd - source array start index
            // 3rd - destination array
            // 4th - destination array start index
            // 5th - length of copying elements
            Array.Copy(original, i * n, ans[i], 0, n);
        }

        return ans;
    }
}