using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class AcmIcpcTeam : IChallenge
    {
        //https://www.hackerrank.com/challenges/acm-icpc-team

        public void Solve()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            string[] topic = new string[n];
            for (int topic_i = 0; topic_i < n; topic_i++)
            {
                topic[topic_i] = Console.ReadLine();
            }

            List<List<bool>> list = topic.ToList().Select(x => x.ToList().Select(y => y == '1').ToList()).ToList();
            int result = 0;
            int maxAmount = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    int amount = 0;

                    for (int k = 0; k < m; k++)
                    {
                        if (list[i][k] || list[j][k])
                            amount++;
                    }

                    if (maxAmount < amount)
                    {
                        maxAmount = amount;
                        result = 1;
                    }
                    else if (maxAmount == amount)
                        result++;
                }
            }

            Console.WriteLine(maxAmount);
            Console.WriteLine(result);
        }
    }
}
