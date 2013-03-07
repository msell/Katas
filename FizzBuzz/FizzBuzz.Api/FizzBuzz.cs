using System;
using System.Diagnostics.Contracts;
using System.Globalization;

namespace FizzBuzzer
{
   public interface IFizzBuzz
   {
      string Fizz { get; set; }
      string Buzz { get; set; }
      int FizzDivisor { get; set; }
      int BuzzDivisor { get; set; }
      void Run(int minValue, int maxValue, Action<string> result);
   }

   public class FizzBuzz : IFizzBuzz
   {
      public FizzBuzz()
      {
         Fizz = "Fizz";
         Buzz = "Buzz";
         FizzDivisor = 3;
         BuzzDivisor = 5;
      }

      public string Fizz { get; set; }
      public string Buzz { get; set; }
      public int FizzDivisor { get; set; }
      public int BuzzDivisor { get; set; }

      public void Run(int minValue, int maxValue, Action<string> result)
      {
         if (maxValue < minValue)
            throw new ArgumentException("maxValue must be greater than minValue");

         for (var i = minValue; i <= maxValue; i++)
         {
            if (i % FizzDivisor == 0 && i % BuzzDivisor == 0)
            {
               result.Invoke(string.Concat(Fizz, Buzz));
               continue;
            }

            if (i % FizzDivisor == 0)
            {
               result.Invoke(Fizz);
               continue;
            }

            if (i % BuzzDivisor == 0)
            {
               result.Invoke(Buzz);
               continue;
            }

            result.Invoke(i.ToString(CultureInfo.InvariantCulture));
         }
      }
   }

  
}
