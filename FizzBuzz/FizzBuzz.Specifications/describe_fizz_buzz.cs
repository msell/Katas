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

      Because of = () => fizzBuzz.Run(1, 20, (x) => number_of_results_recieved += 1);

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
         exception = Catch.Exception(() => fizzBuzz.Run(200, 20, (x)=>{}));
      };

      It should_return_an_error = () => exception.ShouldBe(typeof (ArgumentException));
   }

   [Subject("Fizz Buzz")]
   public class when_fizz_divisor_is_zero
   {
      static FizzBuzz fizzBuzz;
      static Exception exception;
      static int number_of_results_recieved;

      Establish context = () =>
      {
         fizzBuzz = new FizzBuzz{FizzDivisor = 0};
      };

      Because of = () =>
      {
         exception = Catch.Exception(() => fizzBuzz.Run(200, 20, (x) => { }));
      };

      It should_not_allow_the_user_to_divide_by_zero = () => exception.ShouldBe(typeof(DivideByZeroException));
   }

   [Subject("Fizz Buzz")]
   public class when_buzz_divisor_is_zero
   {
      static FizzBuzz fizzBuzz;
      static Exception exception;
      static int number_of_results_recieved;

      Establish context = () =>
      {
         fizzBuzz = new FizzBuzz { BuzzDivisor = 0 };
      };

      Because of = () =>
      {
         exception = Catch.Exception(() => fizzBuzz.Run(200, 20, (x) => { }));
      };

      It should_not_allow_the_user_to_divide_by_zero = () => exception.ShouldBe(typeof(DivideByZeroException));
   }

}
