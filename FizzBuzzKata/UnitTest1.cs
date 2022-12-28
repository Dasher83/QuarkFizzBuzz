using FizzBuzz;

namespace FizzBuzzKata
{
    public class UnitTest1
    {
        [Fact]
        public void TestReturnSameNumber()
        {
            #region -- Arrange --
            int numberNotDivisibleBy3Nor5 = GetNumberNotDivisibleBy3Nor5();
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
                int numberDivisibleBy3 = GetNumberDivisibleBy3();
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
            int numberDivisibleBy5 = GetNumberDivisibleBy5();
            #endregion

            #region -- Act --
            //Expected -> "Buzz"
            string result = FizzBuzzCalculator.Check(numberDivisibleBy5);
            #endregion

            #region -- Assert --
            Assert.Equal("Buzz", result);
            #endregion
        }

        //Utils
        private int GetNumberNotDivisibleBy3Nor5()
        {
            Random random = new Random();
            int randomNumber;

            do
            {
                randomNumber = random.Next(1, int.MaxValue);
            } while (randomNumber % 3 == 0 && randomNumber % 5 == 0);

            return randomNumber;
        }
        
        private int GetNumberDivisibleBy3()
        {
            Random random = new Random();
            int randomNumber;

            do
            {
                randomNumber = random.Next(1, int.MaxValue);
            } while (randomNumber % 3 != 0);

            return randomNumber;
        }

        private int GetNumberDivisibleBy5()
        {
            Random random = new Random();
            int randomNumber;

            do
            {
                randomNumber = random.Next(1, int.MaxValue);
            } while (randomNumber % 5 != 0);

            return randomNumber;
        }
    }
}