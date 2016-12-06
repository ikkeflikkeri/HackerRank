using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Strings
{
    class MarsExploration : IChallenge
    {
        //https://www.hackerrank.com/challenges/mars-exploration

        public void Solve()
        {
            string s = Console.ReadLine();

            int counter = 0;

            for (int i = 0; i < s.Length; i += 3)
            {
                if (s[i] != 'S') counter++;
                if (s[i + 1] != 'O') counter++;
                if (s[i + 2] != 'S') counter++;
            }

            Console.WriteLine(counter);
        }
    }
}
