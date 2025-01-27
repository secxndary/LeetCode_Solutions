namespace LeetCode_Solutions;

public partial class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        var result = new bool[candies.Length];

        for (var i = 0; i < candies.Length; i++) {
            if (candies[i] + extraCandies >= candies.Max()) {
                result[i] = true;
            }
        }

        return result;
    }
}