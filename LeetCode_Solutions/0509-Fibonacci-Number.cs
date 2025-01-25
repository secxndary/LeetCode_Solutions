namespace LeetCode_Solutions;

public partial class Solution {
    public int Fib(int n) {
        if (n == 0 || n == 1)
            return n;

        var prev1 = 0;
        var prev2 = 1;

        for (var i = 2; i <= n; i++) {
            var temp = prev2;     // 1 1 2 3 5 ...
            prev2 = prev1 + prev2;   // 1 2 3 5 8 ...
            prev1 = temp;            // 1 1 2 3 5 ...
        }

        return prev2;
    }
}