using System;
using System.Collections.Generic;

namespace csharp_snippets
{
    public class Sol_SearchInsertPosition : Sol
    {
        public override void Test()
        {
            Console.WriteLine($"========={this.GetType().Name}=======1");

            int[] S = new[] {1, 3, 5, 6};
            Console.WriteLine(SearchInsert(S, 5) + " || " + 2);
            S = new[] {1, 3, 5, 6};
            Console.WriteLine(SearchInsert(S, 2) + " || " + 1);
            S = new[] {1, 3, 5, 6};
            Console.WriteLine(SearchInsert(S, 7) + " || " + 4);
        }

        public int SearchInsert(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;
            while (low <= high)
            {
                int mid = (high + low) / 2;
                if (target == nums[mid])
                    return mid;
                if (target < nums[mid])
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            return low;
        }
    }
}