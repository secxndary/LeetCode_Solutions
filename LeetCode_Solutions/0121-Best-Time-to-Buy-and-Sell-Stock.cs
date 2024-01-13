namespace LeetCode_Solutions;

public partial class Solution {
    public int MaxProfit(int[] prices) {
        int left = 0;    // индекс на котором закупаем
        int right = 1;   // индекс на котором продаем
        int maxProfit = 0;

        while (right < prices.Length)
        {
            if (prices[left] > prices[right]) // хуевый закуп (продали дешевле чем купили)
            {
                // если значение в right меньше чем в left, то left можно сразу выкинуть 
                // из  рассмотрения для закупа, т.к. есть более дешевый элемент в right, 
                // который в любом случае будет выгоднее, и сдвинуть на 1 left и right
                left = right;
            }
            else // норм закуп (продали дороже чем купили)
            {
                int profit = prices[right] - prices[left];
                maxProfit = Math.Max(profit, maxProfit);
            }
            right++; // сдвигаем right на 1, left либо тот же, либо сдвинулся на 1
        }
        return maxProfit;
    }
}