namespace LeetCode_Solutions;

public partial class Solution {
    public bool IsSubsequence_WithTwoPointers(string s, string t) {
        var sIndex = 0;
        var tIndex = 0;

        while (sIndex < s.Length && tIndex < t.Length) {
            if (s[sIndex] == t[tIndex]) {
                sIndex++;
            }

            tIndex++;
        }

        return sIndex == s.Length;
    }

    public bool IsSubsequence_WithIndexIterating(string s, string t) {
        var index = 0;

        if (string.IsNullOrEmpty(s))
            return true;

        for (var i = 0; i < t.Length; i++) {
            if (s[index] == t[i])
                index++;
            
            if (index == s.Length)
                return true;
        }

        return false;
    }

    public bool IsSubsequence_WithTwoCharArrays(string s, string t) {
        var sChar = s.ToCharArray();
        var tChar = t.ToCharArray();
        var index = 0;

        if (string.IsNullOrEmpty(s))
            return true;

        for (var i = 0; i < t.Length; i++) {
            if (sChar[index] == tChar[i])
                index++;
            
            if (index == s.Length)
                return true;
        }

        return false;
    }
}