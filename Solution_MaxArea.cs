using System;

namespace core_test_algo
{
    public class Solution_MaxArea
    {
        public void Test()
        {
            Console.WriteLine(MaxArea(new int[] { 1, 1 }) + " - " + 1);
        }
        public int MaxArea(int[] height)
        {
            int maxArea = 0, i = 0;
            int j = height.Length - 1;

            while (i < j)
            {
                maxArea = Math.Max(maxArea, Math.Min(height[i], height[j]) * (j - i));
                if (height[i] < height[j])
                    i++;
                else
                    j++;
            }

            return maxArea;
        }

    }
}