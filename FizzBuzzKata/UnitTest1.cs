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
            int result = FizzBuzzCalculator.Check(numberNotDivisibleBy3Nor5);
            #endregion

            #region -- Assert --
            Assert.Equal(numberNotDivisibleBy3Nor5, result);
            #endregion
        }

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
    }
}