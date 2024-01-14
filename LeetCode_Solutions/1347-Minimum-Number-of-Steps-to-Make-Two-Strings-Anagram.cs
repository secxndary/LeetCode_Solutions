namespace LeetCode_Solutions;

public partial class Solution {
    public int MinSteps(string s, string t) {
        int length = 26;
        int[] lettersS = new int[length];
        int[] lettersT = new int[length];
        int minNumber = 0;

        foreach (char ch in s)
            lettersS[ch - 'a']++;
        foreach (char ch in t)
            lettersT[ch - 'a']++;

        for (int i = 0; i < length; i++)
        {
            if (lettersT[i] < lettersS[i])
            {
                minNumber += Math.Abs(lettersT[i] - lettersS[i]);
            }
        }

        return minNumber;
    }
}