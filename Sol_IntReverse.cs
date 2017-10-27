using System;
using System.Text;

namespace csharp_snippets
{

    public class Sol_IntReverse
    {
        public void Test()
        {
            Console.WriteLine(Reverse(4)+" || 4");
            Console.WriteLine(Reverse(10)+" || 1");
            Console.WriteLine(Reverse(1230)+" || 321");
            Console.WriteLine(Reverse(-10)+" || -1");
            Console.WriteLine(Reverse(-110)+" || -11");
            Console.WriteLine(Reverse(1111111119)+" || 0");
        }
        public int Reverse(int x)
        {
            if (x < 10 && x > -10)
                return x;

            StringBuilder s = new StringBuilder();
            int sign = 1;
            if (x < 0)
            {
                x *= -1;
                sign = -1;
            }

            bool hasNumb = false;
            while (x > 0)
            {
                if (!(!hasNumb && x % 10 == 0))
                {
                    hasNumb = true;
                    s.Append(x % 10);
                }
                x /= 10;
            }

            try{
                return sign * int.Parse(s.ToString());
            }catch{
                return 0;
            }
        }
    }
}