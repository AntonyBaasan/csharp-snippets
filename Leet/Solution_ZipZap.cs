using System;
using System.Text;

namespace core_test_algo
{
    partial class Program
    {
        public class Solution_ZipZaG
        {

            public string Convert(string s, int numRows)
            {
                char[] c = s.ToCharArray();
                int len = c.Length;
                StringBuilder[] sb = new StringBuilder[numRows];
                for (int id = 0; id < sb.Length; id++)
                {
                    sb[id] = new StringBuilder();
                }

                int i = 0;
                while (i < len)
                {
                    for (int idx = 0; idx < numRows && i < len; idx++)
                    {
                        sb[idx].Append(c[i++]);
                    }
                    for (int idx = numRows - 2; idx >= 1 && i < len; idx--)
                    {
                        sb[idx].Append(c[i++]);
                    }
                }
                for (int idx = 1; idx < sb.Length; idx++)
                {
                    sb[0].Append(sb[idx]);
                }

                return sb[0].ToString();
            }

            public void Test()
            {
                Console.WriteLine(Convert("PAYPALISHIRING", 3) + " :: " + "PAHNAPLSIIGYIR");
            }
        }
    }
}
