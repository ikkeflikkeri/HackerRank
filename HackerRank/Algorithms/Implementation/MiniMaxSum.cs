using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class MiniMaxSum : IChallenge
    {
        //https://www.hackerrank.com/challenges/mini-max-sum

        public void Solve()
        {
            List<long> input = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            Console.WriteLine((input.Sum() - input.Max()) + " " + (input.Sum() - input.Min()));
        }
    }
}
