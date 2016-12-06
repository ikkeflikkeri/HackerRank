using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup
{
    class CircularArrayRotation : IChallenge
    {
        //https://www.hackerrank.com/challenges/circular-array-rotation

        public void Solve()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            int q = Convert.ToInt32(tokens_n[2]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            int rotation = k % n;

            for (int a0 = 0; a0 < q; a0++)
            {
                int m = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(m - rotation < 0 ? a[m - rotation + n] : a[m - rotation]);
            }
        }
    }
}
