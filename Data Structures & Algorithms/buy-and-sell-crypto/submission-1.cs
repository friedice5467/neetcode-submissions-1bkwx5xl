public class Solution {
    public int MaxProfit(int[] prices) {
        var maxProfit = 0;
        var minPrice = prices[0];
        for(int i = 1; i < prices.Length; i++)
        {
            var currPrice = prices[i];
            minPrice = Math.Min(minPrice, currPrice);
            maxProfit = Math.Max(maxProfit, currPrice - minPrice);
        }
        return maxProfit;
    }
}
