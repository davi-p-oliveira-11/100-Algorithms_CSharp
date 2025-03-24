/*
2) Write a program that reads a person's name and displays a welcome message for them:  
Example:  
What is your name? João da Silva  
Hello João da Silva, it's a pleasure to meet you!
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class HelloUser
{
   public static void Main(string[] args)
   {
       Algorithm();
       PressEnterToExit();
   } 

   public static void Algorithm()
   {
      Console.WriteLine("What is your name ?");
      string userName = Console.ReadLine();

      Console.WriteLine($"Hello {userName} nice to meet you ! ");
   }

   public static void PressEnterToExit() 
   {
       Console.WriteLine("Press any key to continue...");
       Console.ReadKey();
   }
}