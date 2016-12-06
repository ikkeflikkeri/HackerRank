using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class SherlockAndSquares : IChallenge
    {
        //https://www.hackerrank.com/challenges/sherlock-and-squares

        public void Solve()
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int a = input[0];
                int b = input[1];

                int min = (int)Math.Ceiling(Math.Sqrt(a));
                int max = (int)Math.Floor(Math.Sqrt(b));

                Console.WriteLine(max - min + 1);
            }
        }
    }
}
