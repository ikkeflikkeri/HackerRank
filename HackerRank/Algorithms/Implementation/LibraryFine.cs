using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class LibraryFine : IChallenge
    {
        //https://www.hackerrank.com/challenges/library-fine

        public void Solve()
        {
            string[] tokens_d1 = Console.ReadLine().Split(' ');
            int d1 = Convert.ToInt32(tokens_d1[0]);
            int m1 = Convert.ToInt32(tokens_d1[1]);
            int y1 = Convert.ToInt32(tokens_d1[2]);
            string[] tokens_d2 = Console.ReadLine().Split(' ');
            int d2 = Convert.ToInt32(tokens_d2[0]);
            int m2 = Convert.ToInt32(tokens_d2[1]);
            int y2 = Convert.ToInt32(tokens_d2[2]);

            if (y1 > y2)
                Console.WriteLine(10000);
            else if (y1 == y2 && m1 > m2)
                Console.WriteLine(500 * (m1 - m2));
            else if (y1 == y2 && m1 == m2 && d1 > d2)
                Console.WriteLine(15 * (d1 - d2));
            else
                Console.WriteLine(0);
        }
    }
}
