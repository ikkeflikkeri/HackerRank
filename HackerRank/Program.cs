using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            IChallenge challenge = new Algorithms.Strings.GemStones();
            challenge.Solve();
        }
    }
}