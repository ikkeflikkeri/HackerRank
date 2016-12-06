using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Strings
{
    class FunnyString : IChallenge
    {
        //https://www.hackerrank.com/challenges/funny-string

        public void Solve()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int a0 = 0; a0 < t; a0++)
            {
                string s = Console.ReadLine();
                string r = new string(s.Reverse().ToArray());

                bool isFunny = true;

                for (int i = 1; i < s.Length && isFunny; i++)
                {
                    if (Math.Abs(s[i] - s[i - 1]) != Math.Abs(r[i] - r[i - 1]))
                        isFunny = false;
                }

                Console.WriteLine(isFunny ? "Funny" : "Not Funny");
            }
        }
    }
}
