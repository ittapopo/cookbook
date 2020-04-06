using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;
using System.Collections.Generic;

namespace cookbook
{
    public class Chapter1
    {
        static void Main(string[] args)
        {
            //      Playing with tuples
            /*** 
            int[] scores = { 17, 46, 39, 62, 81, 79, 52, 24, 49 };
            Chapter1 ch1 = new Chapter1();
            int threshold = 40;
            var (average, studentCount, belowAverage) = ch1.GetAverageAndCount(scores, threshold);
            WriteLine($"Average was {Round(average,2)} across {studentCount} students. { (average < threshold ? " Class score below average." : " Class score above average.")}");
            ReadLine();
                        */

            Chapter1 ch1 = new Chapter1();

            Student student = new Student();
            student.Name = "Dirk";
            student.LastName = "Strauss";
            student.CourseCodes = new List<int> {  203, 202, 101 };

            //ch1.OutputInformation(student);

            Professor prof = new Professor();
            prof.Name = "Reinhardt";
            prof.LastName = "Botha";
            prof.TeachesSubjects = new List<string> { "Mobile Development", "Cryptography" };

            //ch1.OutputInformation(prof);

            
            string sValue = "500";
            /**
            if (int.TryParse(sValue, out var intVal))
            {
                WriteLine($"{intVal} is a valid integer");
                // Do something with intVal
            }
            */

            var (original, intVal, isInteger) = sValue.ToInt();
            if (isInteger)
            {
                WriteLine($"{original} is a valid integer");
                // Do something with intVal
            }

            ReadLine();
        }

        public (double average, int studentCount, bool belowAverage) GetAverageAndCount(int[] scores, int threshold)
        {
            var returnTuple = (ave:0D, sCount:0, subAve: true);
            returnTuple = ((double)scores.Sum() / scores.Count(), scores.Count(), 
            returnTuple.ave.CheckIfBelowAverage(threshold));
            return returnTuple;
        }

        public void OutputInformation(object person)
        {
            /**
            if (person is Student student)
            {
                WriteLine($"Student {student.Name} {student.LastName} " +
                    $"is enrolled for courses {String.Join<int>(", ", student.CourseCodes)}");
            }
            if (person is Professor prof)
            {
                WriteLine($"Professor {prof.Name} {prof.LastName} " +
                    $"teaches {String.Join<string>(",", prof.TeachesSubjects)}");
            }
            */
            /**
            if (person is null)
            {
                WriteLine($"Object {nameof(person)} is null");
            }
            */

            switch (person)
            {
                case Student student when (student.CourseCodes.Contains(203)):
                    WriteLine($"Student {student.Name} {student.LastName} is enrolled for course 203.");
                    break;
                case Student student:
                    WriteLine($"Student {student.Name} {student.LastName} is enrolled for courses {String.Join<int>(", ", student.CourseCodes)}");
                    break;
                case Professor prof:
                    WriteLine($"Professor {prof.Name} {prof.LastName} teaches {String.Join<string>(", ", prof.TeachesSubjects)}");
                    break;
                case null:
                    WriteLine($"Object {nameof(person)} is null");
                    break;
                default:
                    WriteLine("Unknown object detected");
                    break;
            }
        }

        public class Student
        {
            public string Name { get; set; }
            public string LastName { get; set; }
            public List<int> CourseCodes { get; set; }
        }

        public class Professor
        {
            public string Name { get; set; }
            public string LastName { get; set; }
            public List<string> TeachesSubjects { get; set; }
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

        public static (string originalValue, int integerValue, bool isInteger) ToInt (this string stringValue)
        {
            var t = (original: stringValue, toIntegerValue: 0, isInt: false);
            if (int.TryParse(stringValue, out var iValue))
            {
                t.toIntegerValue = iValue; t.isInt = true;
            }
            return t;
        }
    }
}
