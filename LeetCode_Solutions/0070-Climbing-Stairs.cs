namespace LeetCode_Solutions;

public partial class Solution {
    private Dictionary<int, int> memo = new();

    public int ClimbStairs(int n) {
        if (n == 0 || n == 1) 
            return 1;

        if (memo.ContainsKey(n)) {
            return memo[n];
        }

        var fibNumber = ClimbStairs(n - 2) + ClimbStairs(n - 1);
        memo[n] = fibNumber;

        return fibNumber;
    }
}