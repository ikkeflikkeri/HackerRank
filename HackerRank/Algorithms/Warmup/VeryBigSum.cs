using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup
{
    class VeryBigSum : IChallenge
    {
        //https://www.hackerrank.com/challenges/a-very-big-sum

        public void Solve()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            long[] arr = Array.ConvertAll(arr_temp, Int64.Parse);

            Console.WriteLine(arr.Sum());
        }
    }
}
