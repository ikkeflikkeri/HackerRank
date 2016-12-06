using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class FlatlandSpaceStations : IChallenge
    {
        //https://www.hackerrank.com/challenges/flatland-space-stations

        public void Solve()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);

            Array.Sort(c);

            int max = 0;

            if (c.Length > 1)
                max = c.Zip(c.Skip(1), (x, y) => y - x).Max() / 2;

            if (c[0] > max)
                max = c[0];
            if (n - c[c.Length - 1] > max)
                max = n - 1 - c[c.Length - 1];

            Console.WriteLine(max);
        }
    }
}
