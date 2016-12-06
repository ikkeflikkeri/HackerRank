using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class UtopianTree : IChallenge
    {
        //https://www.hackerrank.com/challenges/utopian-tree

        public void Solve()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int height = 1;

                for (int i = 0; i < n; i++)
                {
                    if (i % 2 == 0)
                        height *= 2;
                    else
                        height++;
                }

                Console.WriteLine(height);
            }
        }
    }
}
