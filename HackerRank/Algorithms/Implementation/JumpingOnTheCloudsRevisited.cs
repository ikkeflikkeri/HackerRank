using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class JumpingOnTheCloudsRevisited : IChallenge
    {
        //https://www.hackerrank.com/challenges/jumping-on-the-clouds-revisited

        public void Solve()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);

            int position = -1;
            int energy = 100;

            while (position != 0 && energy > 0)
            {
                if (position == -1)
                    position++;

                position += k;
                position %= n;
                energy -= c[position] * 2 + 1;
            }

            Console.WriteLine(energy);
        }
    }
}
