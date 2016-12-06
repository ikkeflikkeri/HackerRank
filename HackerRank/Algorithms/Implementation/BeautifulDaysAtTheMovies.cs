using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class BeautifulDaysAtTheMovies : IChallenge
    {
        //https://www.hackerrank.com/challenges/beautiful-days-at-the-movies

        public void Solve()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Func<int, int> reversed = x => int.Parse(new string(x.ToString().Reverse().ToArray())); 

            int results = 0;

            for (int i = input[0]; i <= input[1]; i++)
            {
                if ((i - reversed(i)) % input[2] == 0)
                    results++;
            }

            Console.WriteLine(results);
        }
    }
}
