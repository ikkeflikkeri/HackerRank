using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Strings
{
    class Pangrams : IChallenge
    {
        //https://www.hackerrank.com/challenges/pangrams

        public void Solve()
        {
            string s = Console.ReadLine().ToLower().Replace(" ", "");

            int letters = s.ToCharArray().GroupBy(x => x).Count();

            Console.WriteLine(letters == 26 ? "pangram" : "not pangram");
        }
    }
}
