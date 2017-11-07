using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp_snippets
{
    public class Sol_PlusOne : Sol
    {
        public override void Test()
        {
            Console.WriteLine($"========={this.GetType().Name}=======1");
        }

        //add 1 to a number which given in int array format
        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }
            int[] newDigit = new int[digits.Length + 1];
            newDigit[0] = 1;
            return newDigit;
        }
    }
}