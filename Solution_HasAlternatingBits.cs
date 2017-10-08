using System;

namespace core_test_algo
{
    // https://leetcode.com/contest/leetcode-weekly-contest-53/
    public class Solution_HasAlternatingBits
    {
        public void Test()
        {
            Console.WriteLine(Solution(12) + " - " + false);
            Console.WriteLine(Solution(5) + " - " + true);
            Console.WriteLine(Solution(7) + " - " + false);
            Console.WriteLine(Solution(14) + " - " + false);
            Console.WriteLine(Solution(21) + " - " + true);
            Console.WriteLine(Solution(9) + " - " + false);
            Console.WriteLine(Solution(1) + " - " + true);
        }

        private bool Solution(int n)
        {
            var result = Convert.ToString(n, 2);
            int len = result.Length;
            int i = 0;
            if (len == 1)
                return true;

            while (len - 1 > i)
            {
                if (result[i] == result[i + 1])
                {
                    return false;
                }
                i++;
            }
            return true;
        }

    }
}