using System.Text;

namespace LeetCode_Solutions;

public partial class Solution {
    public string ReverseWords(string s) {
        var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var n = words.Length;
        var sb = new StringBuilder();

        for (var i = n - 1; i >= 0; i--) {
            sb.Append(words[i]);

            if (i != 0)
                sb.Append(' ');
        }

        return sb.ToString();
    }
}