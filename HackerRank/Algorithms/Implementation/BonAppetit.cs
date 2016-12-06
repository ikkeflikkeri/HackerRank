using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class BonAppetit : IChallenge
    {
        //https://www.hackerrank.com/challenges/bon-appetit

        public void Solve()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] tokens_c = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(tokens_c, Int32.Parse);
            string[] tokens_b = Console.ReadLine().Split(' ');
            int b = Convert.ToInt32(tokens_b[0]);

            int pay = (c.ToList().Sum() - c[k]) / 2;

            Console.WriteLine(pay < b ? (b - pay).ToString() : "Bon Appetit");
        }
    }
}
