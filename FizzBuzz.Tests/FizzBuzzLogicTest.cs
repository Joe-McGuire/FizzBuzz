using FizzBuzz.Logic;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzLogicTest
    {
        private readonly MockFizzBuzzOutput mockOutput = new();

        [TestMethod]
        public void FizzBuzzLogic_WhenEndIsGreaterThanStart_MethodExecutes100Times()
        {
            int start = 1;
            int end = 100;

            FizzBuzzIterator.DoFizzBuzzRange(start, end, mockOutput);

            Assert.AreEqual(100, mockOutput.Executions);
        }

        [TestMethod]
        public void FizzBuzzLogic_WhenEndIsLessThanOrEqualToStart_MethodDoesNotExecute()
        {
            int start = 20;
            int end = 15;

            FizzBuzzIterator.DoFizzBuzzRange(start, end, mockOutput);

            Assert.AreEqual(0, mockOutput.Executions);
        }

        [TestMethod]
        public void FizzBuzzLogic_MultipleOf3_OutputsFizz()
        {
            Assert.AreEqual("Fizz", FizzBuzzChecker.GetFizzBuzzResult(3));
        }

        [TestMethod]
        public void FizzBuzzLogic_MultipleOf5_OutputsBuzz()
        {
            Assert.AreEqual("Buzz", FizzBuzzChecker.GetFizzBuzzResult(5));
        }

        [TestMethod]
        public void FizzBuzzLogic_MultipleOf3And5_OutputsFizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", FizzBuzzChecker.GetFizzBuzzResult(15));
        }

        [TestMethod]
        public void FizzBuzzLogic_NonMultiplesOf3Or5_OutputsValue()
        {
            int testValue = 1;
            Assert.AreEqual(testValue.ToString(), FizzBuzzChecker.GetFizzBuzzResult(testValue));
        }
    }
}