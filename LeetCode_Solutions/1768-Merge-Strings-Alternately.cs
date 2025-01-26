using System.Text;

namespace LeetCode_Solutions;

public partial class Solution {
    public string MergeAlternately_OneCounter(string word1, string word2) {
        var totalLen = word1.Length + word2.Length;
        var merged = new char[totalLen];
        Array.Fill(merged, '.');

        var count1 = 0;
        var count2 = 0;

        for (var i = 0; i < totalLen; i++) {
            Console.WriteLine($"i = {i}");
            Console.WriteLine($"count1 = {count1}");
            Console.WriteLine($"count2 = {count2}");

            if (i % 2 == 0 && count1 < word1.Length || count2 == word2.Length) {
                Console.WriteLine($"ADD_1: merged[{i}] = word1[{count1}] = {word1[count1]}\n");
                merged[i] = word1[count1];
                count1++;
            }
            else if (count2 < word2.Length || count1 == word1.Length) {
                Console.WriteLine($"ADD_2: merged[{i}] = word2[{count2}] = {word2[count2]}\n");
                merged[i] = word2[count2];
                count2++;
            }
        }

        return new string(merged);
    }
    
    public string MergeAlternately_TwoCounters(string word1, string word2) {
        // Пока не дошли до конца самой длинной строки, добавляем
        // в результирующую строку сначала символ из 1-ой строки 
        // (если там еще остались символы), потом символ из 2-ой строки
        // (также если там еще есть символы).

        var i = 0;
        var sb = new StringBuilder();

        while (i < word1.Length || i < word2.Length) {
            if (i < word1.Length)
                sb.Append(word1[i]);
            if (i < word2.Length)
                sb.Append(word2[i]);

            i++;
        }

        return sb.ToString();
    }
}