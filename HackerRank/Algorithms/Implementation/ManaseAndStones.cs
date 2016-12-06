using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class ManaseAndStones : IChallenge
    {
        //https://www.hackerrank.com/challenges/manasa-and-stones

        public void Solve()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine()) - 1;
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());

                if (a > b)
                {
                    int temp = a;
                    a = b;
                    b = temp;
                }

                int min = a * n;
                int max = b * n;
                int diff = b - a;

                if (min == max)
                {
                    Console.WriteLine(min);
                    continue;
                }

                while (min <= max)
                {
                    Console.Write(min + " ");
                    min += diff;
                }
                Console.WriteLine();
            }
        }
    }
}
