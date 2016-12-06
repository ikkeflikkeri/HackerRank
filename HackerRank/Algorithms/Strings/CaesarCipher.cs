using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Strings
{
    class CaesarCipher : IChallenge
    {
        //https://www.hackerrank.com/challenges/caesar-cipher-1

        public void Solve()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            char[] s = Console.ReadLine().ToCharArray();
            int k = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(Encrypt(s[i], k));
            }
        }

        private char Encrypt(char current, int translation)
        {
            if((current >= 'A' && current <= 'Z') || (current >= 'a' && current <= 'z'))
            {
                char start = Char.IsUpper(current) ? 'A' : 'a';
                return (char)(start + (current - start + translation) % 26);
            }

            return current;
        }
    }
}
