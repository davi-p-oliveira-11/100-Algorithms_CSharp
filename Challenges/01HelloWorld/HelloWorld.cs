/*
  1) Write a program that displays the message "Hello, World!" on the screen.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class HelloWorld
{
   public static void Main(string[] args)
   {
      Console.WriteLine("Hello World !");
      PressEnterToExit();
   } 

    public static void PressEnterToExit() 
    {
      Console.WriteLine("Press any key to continue...");
      Console.ReadKey();
    }
}
