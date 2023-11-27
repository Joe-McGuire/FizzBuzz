using FizzBuzz.Logic;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzLogicTest
    {
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