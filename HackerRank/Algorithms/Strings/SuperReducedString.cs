using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Strings
{
    class SuperReducedString : IChallenge
    {
        //https://www.hackerrank.com/challenges/reduced-string

        public void Solve()
        {
            List<char> s = Console.ReadLine().ToCharArray().ToList();

            for (int i = 0; i < s.Count - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    s.RemoveAt(i);
                    s.RemoveAt(i);

                    if (i != 0)
                        i -= 2;
                    else
                        i--;
                }
            }

            Console.WriteLine(s.Count == 0 ? "Empty String" : new string(s.ToArray()));
        }
    }
}
