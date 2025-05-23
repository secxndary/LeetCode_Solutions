namespace LeetCode_Solutions;

public partial class Solution {
    public int MissingNumber(int[] nums) {
        var n = nums.Length;
        var result = 0;

        // Свойства XOR: 
        // 1. x ^ x = 0
        // 2. x ^ 0 = x
        // 3. x ^ x ^ y ^ y ^ z = 0 ^ 0 ^ z = z

        // То есть, при XOR'е последовательности нескольких чисел
        // одинаковые значения взаимно уничтожаются.
        // Таким образом, если в переменной result за'xor'ить все числа 
        // последовательности 2 раза, а одно (пропущенное в изначальной
        // последовательности) число – только один раз, то в итоговой 
        // переменной result остается только искомое пропущенное число.

        // В переменной result xor'им все числа от 1 до n
        for (var i = 1; i <= n; i++)
            result ^= i;

        // xor'им все числа в последовательности nums 
        // (в которой пропущено одно число)
        for (var i = 0; i < n; i++)
            result ^= nums[i];

        // в результате повторяющиеся пары уничтожаются,
        // а остается только одно пропущенное число
        return result;
    }
}