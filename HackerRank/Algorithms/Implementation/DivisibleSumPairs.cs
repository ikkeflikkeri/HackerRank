using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class DivisibleSumPairs : IChallenge
    {
        //https://www.hackerrank.com/challenges/divisible-sum-pairs

        public void Solve()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            int result = 0;

            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    if ((a[i] + a[j]) % k == 0)
                        result++;
                }
            }

            Console.WriteLine(result);
        }
    }
}
