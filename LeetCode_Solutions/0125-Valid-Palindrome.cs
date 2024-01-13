using System.Text.RegularExpressions;

namespace LeetCode_Solutions;

public partial class Solution {
    public bool IsPalindrome(string s) {
        string str = Regex.Replace(s, @"[^a-zA-Z0-9]+", "").ToLowerInvariant();
        char[] charArray = str.ToCharArray();

        Array.Reverse(charArray);
        string strReversed = new string(charArray);

        return str == strReversed;
    }
}