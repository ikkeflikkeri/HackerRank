
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Strings
{
    class GemStones : IChallenge
    {
        //https://www.hackerrank.com/challenges/gem-stones

        public void Solve()
        {
            int n = int.Parse(Console.ReadLine());

            List<char> chars = new List<char>();

            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();

                if (i == 0)
                    chars.AddRange(s.ToCharArray().GroupBy(x => x).Select(x => x.Key).ToList());
                else
                {
                    for (int j = 0; j < chars.Count; j++)
                    {
                        if(!s.Contains(chars[j]))
                        {
                            chars.RemoveAt(j);
                            j--;
                        }
                    }
                }
            }

            Console.WriteLine(chars.Count);
        }
    }
}
