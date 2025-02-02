namespace LeetCode_Solutions;

public partial class Solution {
    public string GcdOfStrings(string str1, string str2) {
        if (str1 + str2 != str2 + str1)
            return string.Empty;

        var gcd = GetGCD(str1.Length, str2.Length);

        return str1.Substring(0, gcd);
    }

    private int GetGCD(int a, int b) {
        while (b != 0) {
            var temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }
}