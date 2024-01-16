namespace LeetCode_Solutions;

public partial class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        var dict = new Dictionary<int, int>();
        if (magazine.Length < ransomNote.Length)
            return false;

        for (var i = 0; i < magazine.Length; i++)
        {
            if (dict.ContainsKey(magazine[i]))
                dict[magazine[i]]++;
            else
                dict[magazine[i]] = 1;
        }

        for (var i = 0; i < ransomNote.Length; i++)
        {
            if (dict.ContainsKey(ransomNote[i]) && dict[ransomNote[i]] > 0)
                dict[ransomNote[i]]--;
            else
                return false;
        }

        return true;
    }
}