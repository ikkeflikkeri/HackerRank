using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Strings
{
    class TwoCharacters : IChallenge
    {
        //https://www.hackerrank.com/challenges/two-characters

        public void Solve()
        {
            int len = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();

            Func<string, bool> isCorrect = word =>
            {
                for (int i = 0; i < word.Length - 1; i++)
                {
                    if (word[i] == word[i + 1])
                        return false;
                }
                return true;
            };

            var characters = s.ToCharArray().GroupBy(x => x).Select(x => new {x.Key, Count = x.Count()}).OrderBy(x => x.Count).ToList();

            if (characters.Count <= 1)
                Console.WriteLine(0);
            else if (characters.Count == 2)
                Console.WriteLine(isCorrect(s) ? s.Length : 0);
            else
            {
                string result = "";

                for (int i = 0; i < characters.Count; i++)
                {
                    for (int j = i + 1; j < characters.Count; j++)
                    {
                        string word = s;

                        for (int x = 0; x < characters.Count; x++)
                        {
                            if(x == i || x == j)
                                continue;

                            word = word.Replace(characters[x].Key.ToString(), "");
                        }

                        if (isCorrect(word))
                        {
                            if (word.Length > result.Length)
                                result = word;
                        }
                    }
                }

                Console.WriteLine(result.Length);
            }
        }
    }
}
