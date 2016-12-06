using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class FairRations : IChallenge
    {
        //https://www.hackerrank.com/challenges/fair-rations

        public void Solve()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string[] B_temp = Console.ReadLine().Split(' ');
            int[] B = Array.ConvertAll(B_temp, Int32.Parse);

            if (B.Sum() % 2 != 0)
                Console.WriteLine("NO");
            else
            {
                int result = 0;

                for (int i = 0; i < N - 1; i++)
                {
                    if (B[i] % 2 != 0)
                    {
                        result += 2;
                        B[i]++;
                        B[i + 1]++;
                    }
                }

                Console.WriteLine(result);
            }
        }
    }
}
