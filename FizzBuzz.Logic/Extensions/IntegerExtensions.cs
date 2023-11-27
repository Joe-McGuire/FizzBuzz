namespace FizzBuzz.Logic.Extensions
{
    public static class IntegerExtensions
    {
        public static bool IsMultipleOf(this int number, int multiple)
        {
            return number % multiple == 0;
        }
    }
}
