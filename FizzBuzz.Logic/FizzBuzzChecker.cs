using FizzBuzz.Logic.Extensions;

namespace FizzBuzz.Logic
{
    public static class FizzBuzzChecker
    {
        public static string GetFizzBuzzResult(int number)
        {
            bool fizz = number.IsMultipleOf(3);
            bool buzz = number.IsMultipleOf(5);

            if (fizz && buzz)
            {
                return "FizzBuzz";
            }
            else if (fizz)
            {
                return "Fizz";
            }
            else if (buzz)
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }
        }
    }
}
