using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup
{
    class PlusMinus : IChallenge
    {
        //https://www.hackerrank.com/challenges/plus-minus

        public void Solve()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            float neg = 0;
            float pos = 0;
            float eq = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                    pos++;
                else if (arr[i] < 0)
                    neg++;
                else
                    eq++;
            }

            Console.WriteLine(pos / n);
            Console.WriteLine(neg / n);
            Console.WriteLine(eq / n);
        }
    }
}
