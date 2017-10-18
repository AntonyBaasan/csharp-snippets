using System;

namespace csharp_snippets
{
    public class Sol_CountBinarySubstrings : Sol
    {
        public override void Test()
        {
            Console.WriteLine(CountBinarySubstrings("00110011") + " = " + 6);
            Console.WriteLine(CountBinarySubstrings("10101") + " = " + 4);
            Console.WriteLine(CountBinarySubstrings("00110") + " = " + 3);
        }

        public int CountBinarySubstrings(string s)
        {
            int result = 0;
            if (string.IsNullOrEmpty(s))
                return result;

            int pre = 0;
            int cur = 1;
            int count = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                    cur++;
                else
                {
                    pre = cur;
                    cur = 1;
                }

                if (pre >= cur)
                    count++;
            }
            return count;
        }
    }
}