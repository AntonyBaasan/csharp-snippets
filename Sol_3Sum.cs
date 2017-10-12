using System;
using System.Collections.Generic;

namespace csharp_snippets
{
    public class Sol_3Sum
    {
        public void Test()
        {
            int[] S = new[] { -1, 0, 1, 2, -1, -4 };
            var res = ThreeSum(S);

            foreach (var r in res)
            {
                foreach (var i in r)
                    Console.Write(i + " || ");
                Console.WriteLine();
            }
        }

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var res = new List<IList<int>>();
            if (nums.Length < 3)
                return res;

            Array.Sort(nums);

            int sum = 0;
            int j = 0;
            int k = 0;

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                j = i + 1;
                k = nums.Length - 1;
                while (j < k)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1])
                    {
                        j++;
                        continue;
                    }
                    if (k < nums.Length - 1 && nums[k] == nums[k + 1])
                    {
                        k--;
                        continue;
                    }

                    sum = nums[i] + nums[j] + nums[k];
                    if (sum == 0 && nums[i] <= nums[j] && nums[j] <= nums[k])
                    {
                        var r = new List<int>();
                        r.Add(nums[i]);
                        r.Add(nums[j]);
                        r.Add(nums[k]);
                        res.Add(r);
                        j++;
                        k--;
                    }

                    if (sum > 0)
                        k--;
                    if (sum < 0)
                        j++;
                }
            }

            return res;
        }
    }
}