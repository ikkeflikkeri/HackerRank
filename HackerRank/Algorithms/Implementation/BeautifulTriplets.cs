using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class BeautifulTriplets : IChallenge
    {
        //https://www.hackerrank.com/challenges/beautiful-triplets

        public void Solve()
        {
            int[] input1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int n = input1[0];
            int d = input1[1];

            int result = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int calc1 = input2[j] - input2[i];

                    if (calc1 > d)
                        break;

                    if (calc1 != d)
                        continue;

                    for (int k = j + 1; k < n; k++)
                    {
                        int calc2 = input2[k] - input2[j];

                        if (calc2 > d)
                            break;

                        if (calc2 == d)
                            result++;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
