using System;
using System.Collections.Generic;
using System.Linq;

namespace core_test_algo
{
    // https://leetcode.com/contest/leetcode-weekly-contest-53/

    public class Solution_NumberOfDistinctIslands
    {
        public void Test()
        {
            int[,] grid1 = new int[,]{  {1,1,0,0,0},
                                        {1,1,0,0,0},
                                        {0,0,0,1,1},
                                        {0,0,0,1,1}};
            Console.WriteLine(NumDistinctIslands(grid1) + " - " + 1);

            int[,] grid2 = new int[,]{  {1,1,0,1,1},
                                        {1,0,0,0,0},
                                        {0,0,0,0,1},
                                        {1,1,0,1,1}};
            Console.WriteLine(NumDistinctIslands(grid2) + " - " + 3);

            int[,] grid3 = new int[,] { { 1, 1, 1, 1 } };
            Console.WriteLine(NumDistinctIslands(grid3) + " - " + 1);

            int[,] grid4 = new int[,]{  {1,1,0,1,1},
                                        {1,1,0,0,0},
                                        {0,0,0,1,1},
                                        {1,1,0,1,1}};
            Console.WriteLine(NumDistinctIslands(grid4) + " - " + 2);

            int[,] grid5 = new int[,]{  {1,1,0,},
                                        {0,1,1},
                                        {0,0,0},
                                        {1,1,1},
                                        {0,1,0}};
            Console.WriteLine(NumDistinctIslands(grid5) + " - " + 2);
        }

        private int NumDistinctIslands(int[,] grid)
        {
            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);
            var islands = new HashSet<List<List<int>>>();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    var island = new List<List<int>>();

                    if (Dfs(grid, i, j, i, j, rows, cols, island))
                        if (!ContainsIsland(islands, island))
                            islands.Add(island);
                }
            }

            return islands.Count;
        }

        private bool ContainsIsland(HashSet<List<List<int>>> islands, List<List<int>> island)
        {
            if (islands.Count == 0)
                return false;
            foreach (var oldIsland in islands)
            {
                if (oldIsland.Count != island.Count())
                    continue;
                for (int i = 0; i < oldIsland.Count; i++)
                {
                    if (!oldIsland[i].SequenceEqual(island[i]))
                        return false;
                }
            }
            return true;
        }

        private bool Dfs(int[,] grid, int i0, int j0, int i, int j, int m, int n, List<List<int>> island)
        {
            if (i < 0 || m <= i || j < 0 || n <= j || grid[i, j] <= 0) return false;

            island.Add((new int[] { i - i0, j - j0 }).ToList());

            grid[i, j] *= -1;

            int[] xDiff = new int[] { 0, 1, 0, -1 };
            int[] yDiff = new int[] { 1, 0, -1, 0 };

            for (int d = 0; d < 4; d++)
                Dfs(grid, i0, j0, i + xDiff[d], j + yDiff[d], m, n, island);


            return true;

        }
    }
}