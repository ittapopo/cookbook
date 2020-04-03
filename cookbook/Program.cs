using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;

namespace cookbook
{
    public class Chapter1
    {
        static void Main(string[] args)
        {
            int[] scores = { 17, 46, 39, 62, 81, 79, 52, 24, 49 };
            Chapter1 ch1 = new Chapter1();
            int threshold = 40;
            var (average, studentCount, belowAverage) = ch1.GetAverageAndCount(scores, threshold);
            WriteLine($"Average was {Round(average,2)} across {studentCount} students. { (average < threshold ? " Class score below average." : " Class score above average.")}");
            ReadLine();
        }

        public (double average, int studentCount, bool belowAverage) GetAverageAndCount(int[] scores, int threshold)
        {
            var returnTuple = (ave:0D, sCount:0, subAve: true);
            returnTuple = ((double)scores.Sum() / scores.Count(), scores.Count(), 
            returnTuple.ave.CheckIfBelowAverage(threshold));
            return returnTuple;
        }
    }

    public static class ExtensionMethods
    {
        public static bool CheckIfBelowAverage(this double classAverage, int threshold)
        {
            if (classAverage < threshold)
            {
                // Notify head of department
                return true;
            }
            else
                return false;
        }
    }
}
