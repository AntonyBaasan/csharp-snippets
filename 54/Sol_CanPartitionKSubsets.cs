using System;

namespace csharp_snippets
{
    public class Sol_CanPartitionKSubsets : Sol
    {
        public override void Test()
        {
            int[] num1 = new int[] { 4, 3, 2, 3, 5, 2, 1 };
            int k1 = 4;
            Console.WriteLine(CanPartitionKSubsets(num1, k1) + " " + true);

            int[] num2 = new int[] { 2, 1, 4, 5, 6 };
            int k2 = 3;
            Console.WriteLine(CanPartitionKSubsets(num2, k2) + " " + true);

            int[] num3 = new int[] { 2, 1, 5, 5, 6 };
            int k3 = 3;
            Console.WriteLine(CanPartitionKSubsets(num3, k3) + " " + false);
        }
        public bool CanPartitionKSubsets(int[] nums, int k)
        {
            int n = nums.Length;
            if (k == 1)
                return true;
            if (n < k)
                return false;

            int sum = 0;
            for (int i = 0; i < n; i++)
                sum += nums[i];
            if (sum % k != 0)
                return false;

            int subset = sum / k;
            int[] subsetSum = new int[k];
            bool[] taken = new bool[n];

            for (int i = 0; i < k; i++)
                subsetSum[i] = 0;
            for (int i = 0; i < n; i++)
                taken[i] = false;

            subsetSum[0] = nums[n - 1];
            taken[n - 1] = true;


            return CanPartitionKSubsets(nums, subsetSum, taken, subset, k, n, 0, n - 1);
        }

        private bool CanPartitionKSubsets(int[] nums, int[] subsetSum, bool[] taken, int subset, int k, int n, int curIdx, int limitIdx)
        {
            if (subsetSum[curIdx] == subset)
            {
                if (curIdx == k - 2)
                    return true;
                return CanPartitionKSubsets(nums, subsetSum, taken, subset, k, n, curIdx + 1, n - 1);
            }

            for (int i = limitIdx; i >= 0; i--)
            {
                if (taken[i])
                    continue;
                int tmp = subsetSum[curIdx] + nums[i];

                if (tmp <= subset)
                {
                    taken[i] = true;
                    subsetSum[curIdx] += nums[i];
                    bool nxt = CanPartitionKSubsets(nums, subsetSum, taken, subset, k, n, curIdx, i - 1);
                    taken[i] = false;
                    subsetSum[curIdx] -= nums[i];
                    if (nxt)
                        return true;
                }
            }
            return false;
        }
    }
}