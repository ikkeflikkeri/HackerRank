using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class AngryProfessor : IChallenge
    {
        //https://www.hackerrank.com/challenges/angry-professor

        public void Solve()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            Console.WriteLine(a.ToList().FindAll(x => x <= 0).Count >= k ? "NO" : "YES");
        }
    }
}
