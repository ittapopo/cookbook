using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace cookbook
{
    public class Chapter1
    {
        static void Main(string[] args)
        {
            int[] scores = { 17, 46, 39, 62, 81, 79, 52, 24 };
            Chapter1 ch1 = new Chapter1();
            var (average, studentCount) = ch1.GetAverageAndCount(scores);
            WriteLine($"Average was {average} across {studentCount} students");
            ReadLine();
        }

        public (int average, int studentCount) GetAverageAndCount(int[] scores)
        {
            var returnTuple = (ave:0, sCount:0);
            returnTuple = (scores.Sum()/scores.Count(), scores.Count());
            return returnTuple;
        }
    }
}
