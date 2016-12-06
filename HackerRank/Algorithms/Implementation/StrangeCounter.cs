using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class StrangeCounter : IChallenge
    {
        //https://www.hackerrank.com/challenges/strange-code

        public void Solve()
        {
            BigInteger t = BigInteger.Parse(Console.ReadLine());

            BigInteger remainder = 3;

            while (t > remainder)
            {
                t -= remainder;
                remainder *= 2;
            }

            Console.WriteLine(remainder - t + 1);
        }
    }
}
