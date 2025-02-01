namespace LeetCode_Solutions;

public partial class Solution {
    private HashSet<char> vowels = new HashSet<char>() {
        'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' 
    };

    public string ReverseVowels(string s) {
        var c = s.ToCharArray();
        var left = 0;
        var right = s.Length - 1;

        while (left < right) {
            if (IsVowel(c[right]) && IsVowel(c[left])) {
                var temp = c[left];
                c[left] = c[right];
                c[right] = temp;

                left++;
                right--;
            }

            if (IsConsonant(c[left])) {
                left++;
            }

            if (IsConsonant(c[right])) {
                right--;
            }
        }

        return new string(c);
    }

    private bool IsVowel(char c) => vowels.Contains(c);

    private bool IsConsonant(char c) => !vowels.Contains(c);
}