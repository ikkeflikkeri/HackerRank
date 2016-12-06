using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup
{
    class SimpleArraySum : IChallenge
    {
        //https://www.hackerrank.com/challenges/simple-array-sum

        public void Solve()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            Console.WriteLine(arr.Sum());
        }
    }
}
