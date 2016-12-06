using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class HappyLadybugs : IChallenge
    {
        //https://www.hackerrank.com/challenges/happy-ladybugs

        public void Solve()
        {
            int Q = Convert.ToInt32(Console.ReadLine());

            for (int a0 = 0; a0 < Q; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string b = Console.ReadLine();

                bool result;

                if (b.Contains('_'))
                    result = b.Replace("_", "").Length == 0 || b.Where(x => x != '_').GroupBy(x => x).Select(x => x.Count()).All(x => x > 1);
                else
                    result = !new Regex(@"(.)(?!\1)(?<!\1{2})").IsMatch(b);

                Console.WriteLine(result ? "YES" : "NO");
            }
        }
    }
}