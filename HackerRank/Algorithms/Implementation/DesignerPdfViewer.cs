using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class DesignerPdfViewer : IChallenge
    {
        //https://www.hackerrank.com/challenges/designer-pdf-viewer

        public void Solve()
        {
            string[] h_temp = Console.ReadLine().Split(' ');
            int[] h = Array.ConvertAll(h_temp, Int32.Parse);
            string word = Console.ReadLine();

            Console.WriteLine(word.Select(t => h[t - 97]).Concat(new[] {0}).Max()*word.Length);
        }
    }
}
