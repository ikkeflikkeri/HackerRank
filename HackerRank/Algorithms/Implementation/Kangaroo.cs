using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class Kangaroo : IChallenge
    {
        //https://www.hackerrank.com/challenges/kangaroo

        public void Solve()
        {
            string[] tokens_x1 = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(tokens_x1[0]);
            int v1 = Convert.ToInt32(tokens_x1[1]);
            int x2 = Convert.ToInt32(tokens_x1[2]);
            int v2 = Convert.ToInt32(tokens_x1[3]);

            bool isGapClosing = v2 < v1;

            int x = x2 - x1;
            int v = v2 - v1;

            Console.WriteLine(isGapClosing && x % v == 0 ? "YES" : "NO");
        }
    }
}
