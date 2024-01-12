namespace LeetCode_Solutions;

public partial class Solution {
    public bool HalvesAreAlike(string s) {
        int CountVowels(string str) 
        {
            int count = 0;
            HashSet<char> vowels = new HashSet<char> 
            {
                'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'
            };
            for (int i = 0; i < str.Length; i++)
                if (vowels.Contains(str[i]))
                    count++;
            return count;
        }

        int length = s.Length;
        int splitIndex = length / 2;

        string a = s.Substring(0, splitIndex);
        string b = s.Substring(splitIndex);

        return CountVowels(a) == CountVowels(b);
    }
}