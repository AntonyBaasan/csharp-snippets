using System;
using System.Collections.Generic;

namespace csharp_snippets
{
    public class Sol_MaxSubarray : Sol
    {
        public override void Test()
        {
            Console.WriteLine($"========={this.GetType().Name}=======1");

            int[] S = new[] {-2, 1, -3, 4, -1, 2, 1, -5, 4};
            Console.WriteLine(MaxSubArray(S) + " || " + 6);
        }

        public int MaxSubArray(int[] nums)
        {
            int[] dp = new int[nums.Length];

            dp[0] = nums[0];
            int max = nums[0];
            int sum = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                dp[i] = nums[i] + (dp[i - 1] > 0 ? dp[i - 1] : 0);
                if (dp[i] > max)
                    max = dp[i];
            }

            return max;
        }
    }
}