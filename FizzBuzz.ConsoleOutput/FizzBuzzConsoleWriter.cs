using FizzBuzz.Logic;

namespace FizzBuzz.ConsoleOutput
{
    public class FizzBuzzConsoleWriter : IFizzBuzzOutput
    {
        public void OutputFizzBuzzResult(int number)
        {
            Console.WriteLine(FizzBuzzChecker.GetFizzBuzzResult(number));
        }
    }
}
