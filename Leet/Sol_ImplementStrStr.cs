using System;
using System.Text;

namespace csharp_snippets
{
    // https://leetcode.com/problems/implement-strstr/discuss/
    public class Sol_ImplementStrStr
    {
        public void Test()
        {
            Console.WriteLine(StrStr("mississippi", "issipi") + " || -1");
            Console.WriteLine(StrStr("mississippi", "miss") + " || 0");
        }
        public int StrStr(string haystack, string needle)
        {
            for (int i = 0; ; i++)
            {
                for (int j = 0; ; j++)
                {

                    if (j == needle.Length) return i;
                    if (i + j == haystack.Length) return -1;
                    if (haystack[i + j] != needle[j])
                        break;
                }
            }
        }
    }
}