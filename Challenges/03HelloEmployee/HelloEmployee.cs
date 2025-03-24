/* 
 3) Create a program that reads the name and salary of an employee, and displays a message at the end.

Example:
Employee Name: Jane Doe
Salary: 1850.45
The employee Jane Doe has a salary of R$1850.45 in June.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _100_Algorithms_Csharp.Challenges_03HelloEmployee
{
    public class HelloEmployee
    {
        public static void Main(string[] args)
        {
            Algorithm();
            PressEnterToExit();
        }

        public static void Algorithm()
        {
           Console.WriteLine("What is the employee name ?");
           string? employeeName = Console.ReadLine();

           Console.WriteLine("How much is the employee salary ? ?");
           string? salary = Console.ReadLine();

           Console.WriteLine("Last month worked ?");
           string? month = Console.ReadLine();

           Console.WriteLine($" The Employee {employeeName} has a salary of {salary} in {month} ");
        }

        public static void PressEnterToExit() 
        {
           Console.WriteLine("Press any key to continue...");
           Console.ReadKey();
        }
    }
}