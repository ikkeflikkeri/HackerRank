using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class LisaWorkbook : IChallenge
    {
        //https://www.hackerrank.com/challenges/lisa-workbook

        public void Solve()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] t_temp = Console.ReadLine().Split(' ');
            int[] t = Array.ConvertAll(t_temp, Int32.Parse);

            int page = 1;
            int result = 0;

            for (int i = 0; i < t.Length; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (page == j)
                        result++;

                    if (j % k == 0 || j == i)
                        page++;
                }
            }

            Console.WriteLine(result);
        }
    }
}
