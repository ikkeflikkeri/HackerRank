using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class ModifiedKaprekarNumbers : IChallenge
    {
        //https://www.hackerrank.com/challenges/kaprekar-numbers

        public void Solve()
        {
            int p = Convert.ToInt32(Console.ReadLine());
            int q = Convert.ToInt32(Console.ReadLine());

            bool isFound = false;

            for (int i = p; i <= q; i++)
            {
                long square = (long)i * i;
                if (square % 1 != 0)
                    continue;

                string sqr = square.ToString();

                int d = sqr.Length - i.ToString().Length;
                int r = 0, l = 0;

                if (d > 0)
                    l = int.Parse(sqr.Substring(0, d));
                if (d >= 0)
                    r = int.Parse(sqr.Substring(d));

                if (l + r == i)
                {
                    Console.Write(i + " ");
                    isFound = true;
                }
            }

            if (!isFound)
                Console.WriteLine("INVALID RANGE");
        }
    }
}
