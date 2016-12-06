using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class SockMerchant : IChallenge
    {
        //https://www.hackerrank.com/challenges/sock-merchant

        public void Solve()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);

            Console.WriteLine(c.ToList().GroupBy(x => x).Select(x => x.Count() / 2).Sum());
        }
    }
}
