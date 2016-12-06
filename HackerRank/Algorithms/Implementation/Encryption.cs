using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class Encryption : IChallenge
    {
        //https://www.hackerrank.com/challenges/encryption

        public void Solve()
        {
            string s = Console.ReadLine().Replace(" ", "");

            int rows = (int)Math.Floor(Math.Sqrt(s.Length));
            int columns = (int)Math.Ceiling(Math.Sqrt(s.Length));

            if (rows * columns < s.Length)
                rows++;

            string[] matrix = new string[rows];

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = s.Substring(i * columns, Math.Min(s.Length - i * columns, columns));
            }

            for (int j = 0; j < columns; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    if (j > matrix[i].Length - 1)
                        break;

                    Console.Write(matrix[i][j]);
                }
                Console.Write(" ");
            }
        }
    }
}
