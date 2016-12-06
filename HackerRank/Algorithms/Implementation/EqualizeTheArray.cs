using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class EqualizeTheArray : IChallenge
    {
        //https://www.hackerrank.com/challenges/equality-in-a-array

        public void Solve()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);

            int mostOccuredNumber = c.ToList()
                .GroupBy(x => x)
                .Select(x => new { x.Key, Count = x.Count() })
                .OrderByDescending(x => x.Count)
                .First()
                .Key;

            int removes = c.ToList()
                .Count(x => x != mostOccuredNumber);

            Console.WriteLine(removes);
        }
    }
}
