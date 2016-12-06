using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class TaumAndBday : IChallenge
    {
        //https://www.hackerrank.com/challenges/taum-and-bday

        public void Solve()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_b = Console.ReadLine().Split(' ');
                long b = Convert.ToInt64(tokens_b[0]);
                long w = Convert.ToInt64(tokens_b[1]);
                string[] tokens_x = Console.ReadLine().Split(' ');
                long x = Convert.ToInt64(tokens_x[0]);
                long y = Convert.ToInt64(tokens_x[1]);
                long z = Convert.ToInt64(tokens_x[2]);

                long bPrice = Math.Min(x, y + z);
                long wPrice = Math.Min(y, x + z);

                bPrice *= b;
                wPrice *= w;

                Console.WriteLine(bPrice + wPrice);
            }
        }
    }
}
