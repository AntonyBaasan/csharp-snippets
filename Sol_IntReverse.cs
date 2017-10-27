using System;
using System.Text;

namespace csharp_snippets
{

    public class Sol_IntReverse
    {
        public void Test()
        {
            Console.WriteLine(Reverse(4) + " || 4");
            Console.WriteLine(Reverse(10) + " || 1");
            Console.WriteLine(Reverse(1230) + " || 321");
            Console.WriteLine(Reverse(-10) + " || -1");
            Console.WriteLine(Reverse(-110) + " || -11");
            Console.WriteLine(Reverse(1111111119) + " || 0");
        }
        public int Reverse(int x)
        {
            long r = 0;
            while (x != 0)
            {
                r = r * 10 + x % 10;
                if (r > int.MaxValue || r < int.MinValue)
                    return 0;
                x /= 10;
            }
            return (int)r;
        }
    }
}