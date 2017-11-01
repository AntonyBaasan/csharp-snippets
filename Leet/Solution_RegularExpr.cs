using System;
namespace core_test_algo
{
    public class Solution_RegularExpr
    {
        public void Test()
        {
            Console.WriteLine(IsMatch("aa", "a") + " - " + false);
            Console.WriteLine(IsMatch("aa", "aa") + " - " + true);
            Console.WriteLine(IsMatch("aaa", "aa") + " - " + false);
            Console.WriteLine(IsMatch("aa", "a*") + " - " + true);
            Console.WriteLine(IsMatch("aa", ".*") + " - " + true);
            Console.WriteLine(IsMatch("ab", ".*") + " - " + true);
            Console.WriteLine(IsMatch("aab", "c*a*b") + " - " + true);
            Console.WriteLine(IsMatch("abcd", "d*") + " - " + false);
            Console.WriteLine(IsMatch("ab", ".*c") + " - " + false);
        }
        public bool IsMatch(string s, string p)
        {
            return IsMatch(s, p, 0, 0);
        }

        public bool IsMatch(string s, string p, int i, int j)
        {

            //base case - reached end of pattern
            if (j >= p.Length)
            {
                return i >= s.Length && j >= p.Length;
            }

            if (j + 1 < p.Length && p[j + 1] == '*')
            { //peek ahead for *
                while (i < s.Length && (s[i] == p[j] || p[j] == '.'))
                {
                    if (IsMatch(s, p, i, j + 2)) return true;
                    i++;
                }
                return IsMatch(s, p, i, j + 2);
            }
            else if (i < s.Length && (s[i] == p[j] || p[j] == '.'))
            { //direct 1-to-1 match
                return IsMatch(s, p, i + 1, j + 1);
            }

            return false;
        }
    }
}