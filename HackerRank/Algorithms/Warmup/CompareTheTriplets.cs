using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup
{
    class CompareTheTriplets : IChallenge
    {
        //https://www.hackerrank.com/challenges/compare-the-triplets

        private int a, b;

        public void Solve()
        {
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);

            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);

            Action<int, int> score = (val1, val2) =>
            {
                if (val1 > val2) a++;
                if (val1 < val2) b++;
            };
            
            score(a0, b0);
            score(a1, b1);
            score(a2, b2);

            Console.WriteLine(a + " " + b);
        }
    }
}
