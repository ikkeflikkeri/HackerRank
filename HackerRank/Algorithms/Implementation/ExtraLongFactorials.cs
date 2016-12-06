using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class ExtraLongFactorials : IChallenge
    {
        //https://www.hackerrank.com/challenges/extra-long-factorials

        public void Solve()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Func<int, BigInteger> factorial = null;
            factorial = num => num <= 1 ? 1 : num * factorial(num - 1);

            Console.WriteLine(factorial(n));
        }
    }
}
