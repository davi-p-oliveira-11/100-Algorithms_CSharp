using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100_Algorithms_Csharp.Challenges_06PredecesorSucesor
{
    public class PredecesorSucesor
    {
        public static void Main(string[] args)
        {
            Algorithm();
            PressEnterToExit();
        }

        public static void Algorithm()
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine()!);

            int predecessor = num - 1;
            int successor = num + 1;

            Console.WriteLine($"The predecessor of {num} is {predecessor}");
            Console.WriteLine($"The succesor of {num} is {successor}");
        }

        public static void PressEnterToExit() 
        {
             Console.WriteLine("Press any key to continue...");
             Console.ReadKey();
        }
    }
}