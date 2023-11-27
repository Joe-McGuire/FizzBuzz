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
                return string.Empty;
            }
            else if (fizz)
            {
                return string.Empty;
            }
            else if (buzz)
            {
                return string.Empty;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
