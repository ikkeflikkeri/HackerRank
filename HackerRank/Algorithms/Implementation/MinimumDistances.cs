using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class MinimumDistances : IChallenge
    {
        //https://www.hackerrank.com/challenges/minimum-distances

        public void Solve()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] A_temp = Console.ReadLine().Split(' ');
            List<int> A = Array.ConvertAll(A_temp, Int32.Parse).ToList();

            Dictionary<int, int> results = new Dictionary<int, int>();

            for (int i = 0; i < A.Count; i++)
            {
                int loc = A.FindIndex(i + 1, x => x == A[i]);

                if (!results.ContainsKey(A[i]))
                    results.Add(A[i], loc == -1 ? int.MaxValue : loc - i);
            }

            int result = results.ToList().Min(x => x.Value);

            Console.WriteLine(result == int.MaxValue ? -1 : result);
        }
    }
}
