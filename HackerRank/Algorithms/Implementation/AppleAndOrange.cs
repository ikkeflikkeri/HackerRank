using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class AppleAndOrange : IChallenge
    {
        //https://www.hackerrank.com/challenges/apple-and-orange

        public void Solve()
        {
            string[] tokens_s = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(tokens_s[0]);
            int t = Convert.ToInt32(tokens_s[1]);
            string[] tokens_a = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(tokens_a[0]);
            int b = Convert.ToInt32(tokens_a[1]);
            string[] tokens_m = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            string[] apple_temp = Console.ReadLine().Split(' ');
            int[] apple = Array.ConvertAll(apple_temp, Int32.Parse);
            string[] orange_temp = Console.ReadLine().Split(' ');
            int[] orange = Array.ConvertAll(orange_temp, Int32.Parse);

            Func<int[], int, int, int, int> calculate = (objects, min, max, tree) =>
            {
                return objects.ToList().Count(x => x >= min - tree && x <= max - tree);
            };

            Console.WriteLine(calculate(apple, s, t, a));
            Console.WriteLine(calculate(orange, s, t, b));
        }
    }
}
