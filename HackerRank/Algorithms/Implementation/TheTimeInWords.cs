using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class TheTimeInWords : IChallenge
    {
        //https://www.hackerrank.com/challenges/the-time-in-words

        public void Solve()
        {
            Dictionary<int, string> minutes = new Dictionary<int, string>()
            {
                {1, "one minue"},
                {2, "two minutes"},
                {3, "three minutes"},
                {4, "four minutes"},
                {5, "five minutes"},
                {6, "six minutes"},
                {7, "seven minutes"},
                {8, "eight minutes"},
                {9, "nine minutes"},
                {10, "ten minutes"},
                {11, "eleven minutes"},
                {12, "twelve minutes"},
                {13, "thirteen minutes"},
                {14, "fourteen minutes"},
                {15, "quarter"},
                {16, "sixteen minutes"},
                {17, "seventeen minutes"},
                {18, "eighteen minutes"},
                {19, "nineteen minutes"},
                {20, "twenty minutes"},
                {21, "twenty one minutes"},
                {22, "twenty two minutes"},
                {23, "twenty three minutes"},
                {24, "twenty four minutes"},
                {25, "twenty five minutes"},
                {26, "twenty six minutes"},
                {27, "twenty seven minutes"},
                {28, "twenty eight minutes"},
                {29, "twenty nine minutes"},
                {30, "half"}
            };

            Dictionary<int, string> hours = new Dictionary<int, string>()
            {
                {1, "one"},
                {2, "two"},
                {3, "three"},
                {4, "four"},
                {5, "five"},
                {6, "six"},
                {7, "seven"},
                {8, "eight"},
                {9, "nine"},
                {10, "ten"},
                {11, "eleven"},
                {12, "twelve"},
                {13, "one"}
            };

            int h = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            if (m == 0)
                Console.WriteLine(hours[h] + " o' clock");
            else if (m <= 30)
                Console.WriteLine(minutes[m] + " past " + hours[h]);
            else
                Console.WriteLine(minutes[60 - m] + " to " + hours[h + 1]);
        }
    }
}