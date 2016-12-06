using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class FindDigits : IChallenge
    {
        //https://www.hackerrank.com/challenges/find-digits

        public void Solve()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = n.ToString()
                              .Where(c => c != '0')
                              .Select(c => int.Parse(c.ToString()))
                              .Count(c => n % c == 0);

                Console.WriteLine(result);
            }
        }
    }
}
