using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100_Algorithms_Csharp.Challenges_05AverageOfTwo
{
    public class AverageOfTwo
    {
        public static void Main(string[] args)
        {
             Algorithm();
             PressEnterToExit();
        }

         public static void Algorithm()
         {
             Console.WriteLine("Enter the grade of the first test:");
             double grade1 = double.Parse(Console.ReadLine()!);

             Console.WriteLine("Enter the grade of the second test:");
             double grade2 = double.Parse(Console.ReadLine()!);

             double average = (grade1 + grade2) / 2;

             Console.WriteLine($"The average between {grade1} and {grade2} is {average}");
         }


         public static void PressEnterToExit() 
         {
             Console.WriteLine("Press any key to continue...");
             Console.ReadKey();
         }

    }
}