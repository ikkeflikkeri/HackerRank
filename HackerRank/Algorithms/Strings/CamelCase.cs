using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Strings
{
    class CamelCase : IChallenge
    {
        //https://www.hackerrank.com/challenges/camelcase

        public void Solve()
        {
            string s = Console.ReadLine();

            Console.WriteLine(s.Count(x => x >= 'A' && x <= 'Z') + 1);
        }
    }
}
