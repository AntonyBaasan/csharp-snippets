using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp_snippets
{
    // https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/description/
    // 122
    public class Sol_BestTimeToBuyAndSellStock2 : Sol
    {
        public override void Test()
        {
            Console.WriteLine($"========={this.GetType().Name}=======");
        }

        public int MaxProfit(int[] prices)
        {
            int res = 0;

            for (int i = 1; i < prices.Count(); i++)
                if (prices[i] > prices[i - 1])
                    res += prices[i] - prices[i - 1];

            return res;
        }
    }
}