using System;
using FizzBuzzer;
using Machine.Specifications;

namespace Specifications
{
   [Subject("Fizz Buzz")]
   public class when_using_defaults
   {
      static FizzBuzz fizzBuzz;
      static int number_of_results_recieved;

      Establish context = () =>
         {
            fizzBuzz = new FizzBuzz();
         };

      Because of = () =>
         {
            fizzBuzz.ResultReturned += s => number_of_results_recieved += 1;

            fizzBuzz.Run(1, 20);
         };

      It should_return_a_result_for_each_integer_in_a_range = () => number_of_results_recieved.ShouldEqual(20);
   }

   [Subject("Fizz Buzz")]
   public class when_user_supplies_max_value_less_than_min_value
   {
      static FizzBuzz fizzBuzz;
      static Exception exception;
      static int number_of_results_recieved;

      Establish context = () =>
      {
         fizzBuzz = new FizzBuzz();
      };

      Because of = () =>
      {
         exception = Catch.Exception(() => fizzBuzz.Run(200, 20));
      };

      It should_return_an_error = () => exception.ShouldBe(typeof (ArgumentException));
   }

}
