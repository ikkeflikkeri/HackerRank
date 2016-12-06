using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class CavityMap : IChallenge
    {
        //https://www.hackerrank.com/challenges/cavity-map

        public void Solve()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] grid = new string[n];
            for (int grid_i = 0; grid_i < n; grid_i++)
            {
                grid[grid_i] = Console.ReadLine();
            }

            char[][] result = grid.Select(x => x.ToCharArray()).ToArray();

            for (int i = 1; i < result.Length - 1; i++)
            {
                for (int j = 1; j < result[i].Length - 1; j++)
                {

                    int current = int.Parse(grid[i][j].ToString());
                    int up = int.Parse(grid[i - 1][j].ToString());
                    int down = int.Parse(grid[i + 1][j].ToString());
                    int left = int.Parse(grid[i][j - 1].ToString());
                    int right = int.Parse(grid[i][j + 1].ToString());

                    if (up < current && down < current && left < current && right < current)
                        result[i][j] = 'X';
                }
            }

            string[] print = result.Select(x => new string(x)).ToArray();

            for (int i = 0; i < print.Length; i++)
            {
                Console.WriteLine(print[i]);
            }
        }
    }
}
