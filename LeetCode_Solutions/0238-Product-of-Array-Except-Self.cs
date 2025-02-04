namespace LeetCode_Solutions;

public partial class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] answer = new int[n];

        // Заполняем answer префиксными произведениями
        // (на этом этапе здесь те же данные, что были бы в массиве prefix[])
        answer[0] = 1;
        for (int i = 1; i < n; i++) {
            answer[i] = answer[i - 1] * nums[i - 1];
        }

        // 1. Используем переменную postfix для хранения текущего постфиксного 
        // произведения (вместо создания и хранения всего массива postfix[] 
        // мы сразу записываем в answer[] итоговое значение (prefix[i] * postfix)

        // 2. Обновляем текущее постфиксное значение (умножаем постфикс
        // всех предыдущих значений на текущее значение nums[i])
        var postfix = 1;
        for (int i = n - 1; i >= 0; i--) {
            answer[i] = answer[i] * postfix; // Умножаем префиксное на постфиксное
            postfix *= nums[i]; // Обновляем постфиксное произведение
        }

        return answer;
    }
}