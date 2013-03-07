using FizzBuzzer;
using NUnit.Framework;


namespace Specifications
{
   [TestFixture]
   public class CoreTests
   {
      [TestCase(3, ExpectedResult = "Fizz")]
      [TestCase(6, ExpectedResult = "Fizz")]
      [TestCase(9, ExpectedResult = "Fizz")]
      [TestCase(5, ExpectedResult = "Buzz")]
      [TestCase(10, ExpectedResult = "Buzz")]
      [TestCase(15, ExpectedResult = "FizzBuzz")]
      [TestCase(30, ExpectedResult = "FizzBuzz")]
      [TestCase(35, ExpectedResult = "Buzz")]
      [TestCase(99, ExpectedResult = "Fizz")]
      public string should_return_expected_default_results(int dataPoint)
      {
         var fizzBuzz = new FizzBuzz();
         string result = string.Empty;


         fizzBuzz.Run(dataPoint, dataPoint, (x) => { result = x; });
         return result;
      }

      [TestCase(3, ExpectedResult = "Foo")]
      [TestCase(6, ExpectedResult = "Foo")]
      [TestCase(9, ExpectedResult = "Foo")]
      [TestCase(5, ExpectedResult = "Bar")]
      [TestCase(10, ExpectedResult = "Bar")]
      [TestCase(15, ExpectedResult = "FooBar")]
      public string should_be_able_to_replace_words(int dataPoint)
      {
         var fizzBuzz = new FizzBuzz { Fizz = "Foo", Buzz = "Bar" };
         string result = string.Empty;

         fizzBuzz.Run(dataPoint, dataPoint, (x) => { result = x; });

         return result;
      }

      [TestCase(7, ExpectedResult = "Foo")]
      [TestCase(14, ExpectedResult = "Foo")]
      [TestCase(10, ExpectedResult = "Bar")]
      [TestCase(100, ExpectedResult = "Bar")]
      [TestCase(70, ExpectedResult = "FooBar")]
      public string should_be_able_to_replace_words_and_divisors(int dataPoint)
      {
         var fizzBuzz = new FizzBuzz { Fizz = "Foo", Buzz = "Bar", FizzDivisor = 7, BuzzDivisor = 10 };
         string result = string.Empty;

         fizzBuzz.Run(dataPoint, dataPoint, (x) => { result = x; });

         return result;
      }
   }
}
