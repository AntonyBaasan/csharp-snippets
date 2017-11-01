using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp_snippets
{
    // https://leetcode.com/contest/leetcode-weekly-contest-55/problems/minimum-ascii-delete-sum-for-two-strings/
    // 712
    public class Sol_MinASCIIDeleteSumForTwoStrings : Sol
    {
        public override void Test()
        {
            Console.WriteLine($"========={this.GetType().Name}=======");

            Console.WriteLine(MinimumDeleteSum("sea", "eat") + " || " + 231);
            // Console.WriteLine(MinimumDeleteSum("delete", "leet") + " || " + 403);

        }

        public int MinimumDeleteSum(string s1, string s2)
        {
            int[,] count = new int[s1.Length + 1, s2.Length + 1];

            for (int i = 1; i < count.GetLength(0); i++)
                count[i, 0] = count[i - 1, 0] + (int)s1[i - 1];

            for (int i = 1; i < count.GetLength(1); i++)
                count[0, i] = count[0, i - 1] + (int)s2[i - 1];

            for (int i = 1; i < count.GetLength(0); i++)
            {
                for (int j = 1; j < count.GetLength(1); j++)
                {
                    int cost = (s1[i - 1] == s2[j - 1]) ? 0 : (int)s1[i - 1] + (int)s2[j - 1];
                    count[i, j] = Math.Min(count[i - 1, j] + s1[i - 1], count[i, j - 1] + s2[j - 1]);
                    count[i, j] = Math.Min(count[i, j], count[i - 1, j - 1] + cost);
                }
            }

            return count[s1.Length, s2.Length];
        }

        public void Print(int[,] arr)
        {
            Console.WriteLine("------------------");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    // Console.Write(Convert.ToChar(arr[i, j])+ " ");
                    Console.Write(arr[i, j]+ " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------");
        }
    }
}