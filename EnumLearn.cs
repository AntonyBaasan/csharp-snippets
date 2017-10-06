using System;

namespace core_test_algo
{
    public enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
    [Flags]
    public enum DaysFlag { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
    public class EnumLearn
    {
        public void Test(){
            var day1 = Days.Wed;
            Console.WriteLine("day1: "+(int)day1);
            var day2 = DaysFlag.Wed;
            Console.WriteLine("day2: "+(int)day2);
        }
    }
}