using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cookbook
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 17, 46, 39, 62, 81, 79, 52, 24 };
            Chapter1 ch1 = new Chapter1();
            var s = ch1.GetAverageAndCount(scores);
        }
    }

    public class Chapter1
    {
        public (int, int) GetAverageAndCount(int[] scores)
        {
            var returnTuple = (0, 0);
            return returnTuple;
        }
    }
}
