namespace LeetCode_Solutions;

public partial class Solution {
    public bool IsAnagram(string s, string t) {
        int len = 'z' - 'a' + 1;
        int[] letters = new int[len];

        for (int i = 0; i < s.Length; i++)
            letters[s[i] - 'a']++;
        for (int i = 0; i < t.Length; i++)
            letters[t[i] - 'a']--;

        for (int i = 0; i < len; i++)
            if (letters[i] != 0)
                return false;

        return true;
    }
}