using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup
{
    class TimeConversion : IChallenge
    {
        //https://www.hackerrank.com/challenges/time-conversion

        public void Solve()
        {
            string time = Console.ReadLine();

            Console.WriteLine(DateTime.Parse(time).ToString("HH:mm:ss"));
        }
    }
}
