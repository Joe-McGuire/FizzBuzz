using FizzBuzz.Logic;

namespace FizzBuzz.Tests
{
    internal class MockFizzBuzzOutput : IFizzBuzzOutput
    {
        internal int Executions { get; private set; } = 9999;

        public void OutputFizzBuzzResult(int number)
        {

        }
    }
}
