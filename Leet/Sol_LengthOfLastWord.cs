using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp_snippets
{
    public class Sol_LegthOfLastWord : Sol
    {
        public override void Test()
        {
            Console.WriteLine($"========={this.GetType().Name}=======1");

            var s = "Hello World";
            Console.WriteLine(LengthOfLastWord(s) + " || " + 5);
            s = "a ";
            Console.WriteLine(LengthOfLastWord(s) + " || " + 1);
        }

        public int LengthOfLastWord(string s)
        {
            
            string[] parts = s.Trim().Split(' ');
            if (parts.Length == 0)
                return 0;
            return parts.Last().Length;
        }
    }
}