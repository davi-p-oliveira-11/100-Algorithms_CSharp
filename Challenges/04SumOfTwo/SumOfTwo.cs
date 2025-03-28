/* 
4) Develop an algorithm that reads two integers and displays the sum between them.  
Example:  
Enter a value: 8  
Enter another value: 5  
The sum of 8 and 5 is 13.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace  _100_Algorithms_Csharp.Challenges_04SumOfTwo
{
    public class SumOfTwo
    {
        public static void Main(string[] args)
        {
            Algorithm();
            PressEnterToExit();
        }

        public static void Algorithm()
        {
            Console.WriteLine("Type a number: ");
            int num1 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Type another number: ");
            int num2 = int.Parse(Console.ReadLine()!);

            int sumOfTwo = num1 + num2;

            Console.WriteLine($"The sum between {num1} and {num2} is {sumOfTwo}");
        }


        public static void PressEnterToExit() 
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}