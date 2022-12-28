using FizzBuzz;

namespace FizzBuzzKata
{
    public class UnitTest1
    {
        [Fact]
        public void TestReturnSameNumber()
        {
            #region -- Arrange --
            int numberNotDivisibleBy3Nor5 = TestUtilities.GetNumberNotDivisibleBy3Nor5();
            #endregion

            #region -- Act --
            string result = FizzBuzzCalculator.Check(numberNotDivisibleBy3Nor5);
            #endregion

            #region -- Assert --
            Assert.Equal(numberNotDivisibleBy3Nor5.ToString(), result);
            #endregion
        }
        [Fact]
        public void TestReturnFizz()
        {
            #region -- Arrange --
                int numberDivisibleBy3 = TestUtilities.GetNumberDivisibleBy3();
            #endregion

            #region -- Act --
                //Expected -> "Fizz"
                string result = FizzBuzzCalculator.Check(numberDivisibleBy3);
            #endregion

            #region -- Assert --
                Assert.Equal("Fizz", result);
            #endregion
        }
        [Fact]
        public void TestReturnBuzz()
        {
            #region -- Arrange --
            int numberDivisibleBy5 = TestUtilities.GetNumberDivisibleBy5();
            #endregion

            #region -- Act --
            //Expected -> "Buzz"
            string result = FizzBuzzCalculator.Check(numberDivisibleBy5);
            #endregion

            #region -- Assert --
            Assert.Equal("Buzz", result);
            #endregion
        }
        [Fact]
        public void TestReturnFizzBuzz()
        {
            #region -- Arrange --
            int numberDivisibleBy3And5 = TestUtilities.GetNumberDivisibleBy3And5();
            #endregion

            #region -- Act --
            //Expected -> "FizzBuzz"
            string result = FizzBuzzCalculator.Check(numberDivisibleBy3And5);
            #endregion

            #region -- Assert --
            Assert.Equal("FizzBuzz", result);
            #endregion
        }
    }
}