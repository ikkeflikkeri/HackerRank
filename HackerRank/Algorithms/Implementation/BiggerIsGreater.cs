using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class BiggerIsGreater : IChallenge
    {
        //https://www.hackerrank.com/challenges/bigger-is-greater

        public void Solve()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int a0 = 0; a0 < t; a0++)
            {
                string w = Console.ReadLine();
                int[] chars = w.ToList().Select(x => (int)x).ToArray();

                int i = chars.Length - 1;

                while (i > 0 && chars[i - 1] >= chars[i])
                    i--;

                if (i > 0)
                {
                    int j = chars.Length - 1;

                    while (chars[j] <= chars[i - 1])
                        j--;

                    int temp = chars[i - 1];
                    chars[i - 1] = chars[j];
                    chars[j] = temp;

                    j = chars.Length - 1;

                    while (i < j)
                    {
                        temp = chars[i];
                        chars[i] = chars[j];
                        chars[j] = temp;
                        i++;
                        j--;
                    }
                }

                string w1 = chars.Aggregate(string.Empty, (s, x) => s + (char)x);

                Console.WriteLine(w1 == w ? "no answer" : w1);
            }
        }
    }
}
