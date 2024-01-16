namespace LeetCode_Solutions;

public partial class Solution {
    public bool IsValid(string s) {
        var opening = new HashSet<char>() {'(', '{', '['};
        var closing = new HashSet<char>() {')', '}', ']'};
        var stack = new Stack<char>();
        var count = 0;

        for (var i = 0; i < s.Length; i++) {
            if (opening.Contains(s[i])) {
                count++;
                stack.Push(s[i]);
            }

            if (closing.Contains(s[i])) {
                count--;
                if (stack.Count > 0 && Math.Abs(s[i] - stack.Pop()) > 2) {
                    return false;
                }
            }
        }

        return count == 0 && stack.Count == 0;
    }
}