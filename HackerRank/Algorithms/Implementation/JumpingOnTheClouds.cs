using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class JumpingOnTheClouds : IChallenge
    {
        //https://www.hackerrank.com/domains/algorithms/implementation/page:3

        public void Solve()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);

            int pos = 0;
            int result = 0;

            while (pos < c.Length - 1)
            {
                if (pos + 2 < c.Length && c[pos + 2] == 0)
                    pos += 2;
                else if (c[pos + 1] == 0)
                    pos++;

                result++;
            }

            Console.WriteLine(result);
        }
    }
}
