using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp_snippets
{
    // https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/
    // 121
    public class Sol_BestTimeToBuyAndSellStock1 : Sol
    {
        public override void Test()
        {
            Console.WriteLine($"========={this.GetType().Name}=======");

            int[] S = new[] { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine(MaxProfit(S) + " || " + 5);

            S = new[] { 7, 6, 4, 3, 1 };
            Console.WriteLine(MaxProfit(S) + " || " + 0);
        }

        public int MaxProfit(int[] prices)
        {
            int min = 100000;
            int max = 0;

            for (int i = 0; i < prices.Count(); i++)
            {
                min = Math.Min(min, prices[i]);
                max = Math.Max(max, prices[i] - min);
            }

            return max;
        }
    }
}