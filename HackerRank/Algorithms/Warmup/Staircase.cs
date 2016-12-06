using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup
{
    class Staircase : IChallenge
    {
        //https://www.hackerrank.com/challenges/staircase

        public void Solve()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new String(' ', n - 1 - i) + new String('#', i + 1));
            }
        }
    }
}
