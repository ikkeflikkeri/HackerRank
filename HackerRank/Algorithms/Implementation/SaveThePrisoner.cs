using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class SaveThePrisoner : IChallenge
    {
        //https://www.hackerrank.com/challenges/save-the-prisoner

        public void Solve()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int m = Convert.ToInt32(tokens_n[1]);
                int s = Convert.ToInt32(tokens_n[2]);

                Console.WriteLine((s + m - 1) % n == 0 ? n : (s + m - 1) % n);
            }
        }
    }
}
