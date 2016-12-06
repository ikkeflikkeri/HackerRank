using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class ChocolateFeast : IChallenge
    {
        //https://www.hackerrank.com/challenges/chocolate-feast

        public void Solve()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int c = Convert.ToInt32(tokens_n[1]);
                int m = Convert.ToInt32(tokens_n[2]);

                int buyin = n/c;
                int totalWraps = 0;
                int wrappers = buyin;

                while (wrappers >= m)
                {
                    int temp = wrappers/m;
                    totalWraps += temp;
                    temp += wrappers%m;
                    wrappers = temp;
                }

                Console.WriteLine(buyin + totalWraps);
            }
        }
    }
}