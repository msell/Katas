using System;
using FizzBuzzer;

namespace SampleApplication
{
   class Program
   {
      static void Main(string[] args)
      {
         var fizzBuzz = new FizzBuzz();

         fizzBuzz.ResultReturned += Console.WriteLine;

         fizzBuzz.Run(1, 2000000000);

         Console.ReadKey();
      }
   }
}
