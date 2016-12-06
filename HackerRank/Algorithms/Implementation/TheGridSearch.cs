using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class TheGridSearch : IChallenge
    {
        //https://www.hackerrank.com/challenges/the-grid-search

        public void Solve()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_R = Console.ReadLine().Split(' ');
                int R = Convert.ToInt32(tokens_R[0]);
                int C = Convert.ToInt32(tokens_R[1]);
                string[] G = new string[R];
                for (int G_i = 0; G_i < R; G_i++)
                {
                    G[G_i] = Console.ReadLine();
                }

                string[] tokens_r = Console.ReadLine().Split(' ');
                int r = Convert.ToInt32(tokens_r[0]);
                int c = Convert.ToInt32(tokens_r[1]);
                string[] P = new string[r];
                for (int P_i = 0; P_i < r; P_i++)
                {
                    P[P_i] = Console.ReadLine();
                }

                bool added = false;

                for (int i = 0; i < G.Length - P.Length + 1 && !added; i++)
                {
                    for (int j = 0; j < G[i].Length - P[0].Length + 1 && !added; j++)
                    {
                        if (G[i][j] == P[0][0])
                        {
                            bool add = true;

                            for (int x = 0; x < P.Length && add; x++)
                            {
                                for (int y = 0; y < P[x].Length && add; y++)
                                {
                                    if (G[i + x][j + y] != P[x][y])
                                        add = false;
                                }
                            }

                            added = add;
                        }
                    }
                }

                Console.WriteLine(added ? "YES" : "NO");
            }
        }
    }
}
