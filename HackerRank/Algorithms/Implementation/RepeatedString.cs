using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class RepeatedString : IChallenge
    {
        //https://www.hackerrank.com/challenges/repeated-string

        public void Solve()
        {
            string s = Console.ReadLine();
            long n = Convert.ToInt64(Console.ReadLine());

            long result = n / s.Length * s.Count(x => x == 'a') + s.Substring(0, (int)(n % s.Length)).Count(x => x == 'a');

            Console.WriteLine(result);
        }
    }
}
