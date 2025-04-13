using System;
using System.Runtime.CompilerServices;
namespace Helloworld{
 class check{ 
         static void Main( String [] args)
         {
          int a =50;                   // For interger numbers
          float pi = 3.14f;            // For floating point numbers
          double salary= 4500.76d;     // For decimal numbers

          // Prints the values of the variables

          System.Console.WriteLine($"The value of a is {a}");
          System.Console.WriteLine($"The value of pi is {pi}");
          System.Console.WriteLine($"The value of salary is {salary}");

          Console.ReadKey();
         }

    }
 }

