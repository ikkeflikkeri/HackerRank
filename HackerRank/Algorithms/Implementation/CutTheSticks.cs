using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class CutTheSticks : IChallenge
    {
        //https://www.hackerrank.com/challenges/cut-the-sticks

        public void Solve()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            List<int> list = Array.ConvertAll(arr_temp, Int32.Parse).ToList();

            while (list.Count > 0)
            {
                Console.WriteLine(list.Count);

                int min = list.Min();
                list.RemoveAll(x => x <= min);
            }
        }
    }
}
