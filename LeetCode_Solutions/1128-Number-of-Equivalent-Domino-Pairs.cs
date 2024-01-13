namespace LeetCode_Solutions;

public partial class Solution {
    public int NumEquivDominoPairs(int[][] dominoes) {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        int count = 0;

        foreach (int[] domino in dominoes)
        {
            var smallNumber = domino[0];
            var bigNumber = domino[1];
            
            if (bigNumber < smallNumber)
                (smallNumber, bigNumber) = (bigNumber, smallNumber);

            smallNumber = smallNumber * 10 + bigNumber;

            if (!dictionary.ContainsKey(smallNumber))
            {
                dictionary.Add(smallNumber, 1);
            }
            else
            {
                count += dictionary[smallNumber];
                dictionary[smallNumber]++;
            }
        }

        return count;
    }
}