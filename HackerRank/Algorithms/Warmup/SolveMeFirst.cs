using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup
{
    class SolveMeFirst : IChallenge
    {
        //https://www.hackerrank.com/challenges/solve-me-first

        public void Solve()
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(val1 + val2);
        }
    }
}
