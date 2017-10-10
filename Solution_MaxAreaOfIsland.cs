using System;

namespace core_test_algo
{
    // https://leetcode.com/contest/leetcode-weekly-contest-53/
    public class Solution_MaxAreaOfIsland
    {
        public void Test()
        {
            int[,] grid1 = new int[,]{  {0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
                                        {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                                        {0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
                                        {0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0},
                                        {0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0},
                                        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                                        {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                                        {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0}};
            Console.WriteLine(MaxAreaOfIsland(grid1) + " - " + 6);

            int[,] grid2 = new int[,] { { 0, 0, 0, 0, 0, 0, 0, 0 } };
            Console.WriteLine(MaxAreaOfIsland(grid2) + " - " + 0);

            int[,] grid3 = new int[,]{  {0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
                                        {0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0},
                                        {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0}};
            Console.WriteLine(MaxAreaOfIsland(grid3) + " - " + 9);
        }

        private int MaxAreaOfIsland(int[,] grid)
        {
            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);
            bool[,] visited  = new bool[rows, cols];

            int maxArea = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == 3 && j == 8)
                        j = 8;
                    CreateVisited(visited, rows, cols);
                    var area = GetArea(grid, i, j, visited, rows, cols);
                    if (area > maxArea)
                        maxArea = area;
                }
            }

            return maxArea;
        }

        private void CreateVisited(bool[,] visited, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    visited[i, j] = false;
                }
            }
        }

        private int GetArea(int[,] grid, int x, int y, bool[,] visited, int rows, int cols)
        {
            if (!InBound(grid, x, y, rows, cols))
            {
                return 0;
            }

            if (visited[x, y])
                return 0;

            visited[x, y] = true;

            if (grid[x, y] == 0)
            {
                return 0;
            }

            int sum = 0;
            sum += GetArea(grid, x - 1, y, visited, rows, cols);
            sum += GetArea(grid, x + 1, y, visited, rows, cols);
            sum += GetArea(grid, x, y - 1, visited, rows, cols);
            sum += GetArea(grid, x, y + 1, visited, rows, cols);
            return 1 + sum;

        }

        private bool InBound(int[,] grid, int x, int y, int rows, int cols)
        {
            return (x >= 0 && x < rows && y >= 0 && y < cols);
        }
    }
}