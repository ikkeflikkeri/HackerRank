using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class BetweenTwoSets : IChallenge
    {
        //https://www.hackerrank.com/challenges/between-two-sets

        public void Solve()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            string[] b_temp = Console.ReadLine().Split(' ');
            int[] b = Array.ConvertAll(b_temp, Int32.Parse);

            int minimum = a.ToList().Max();
            int maximum = b.ToList().Max();
            int result = 0;

            for (int i = minimum; i <= maximum; i++)
            {
                if (a.All(x => i % x == 0) && b.All(x => x % i == 0))
                    result++;
            }

            Console.WriteLine(result);
        }
    }
}
