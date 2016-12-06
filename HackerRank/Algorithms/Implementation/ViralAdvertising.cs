using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class ViralAdvertising : IChallenge
    {
        //https://www.hackerrank.com/challenges/strange-advertising

        public void Solve()
        {
            int n = int.Parse(Console.ReadLine());

            int people = 5;
            int likes = 0;

            for (int i = 0; i < n; i++)
            {
                people = people / 2;
                likes += people;
                people *= 3;
            }

            Console.WriteLine(likes);
        }
    }
}
