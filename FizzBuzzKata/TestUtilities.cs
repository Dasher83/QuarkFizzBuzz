namespace FizzBuzzKata
{
    internal class TestUtilities
    {
        public static int GetNumberNotDivisibleBy3Nor5()
        {
            Random random = new Random();
            int randomNumber;

            do
            {
                randomNumber = random.Next(1, int.MaxValue);
            } while (randomNumber % 3 == 0 || randomNumber % 5 == 0);

            return randomNumber;
        }

        public static int GetNumberDivisibleBy3()
        {
            Random random = new Random();
            int randomNumber;

            do
            {
                randomNumber = random.Next(1, int.MaxValue);
            } while (randomNumber % 3 != 0 || randomNumber % 5 == 0);

            return randomNumber;
        }

        public static int GetNumberDivisibleBy5()
        {
            Random random = new Random();
            int randomNumber;

            do
            {
                randomNumber = random.Next(1, int.MaxValue);
            } while (randomNumber % 5 != 0 || randomNumber % 3 == 0);

            return randomNumber;
        }

        public static int GetNumberDivisibleBy3And5()
        {
            Random random = new Random();
            int randomNumber;

            do
            {
                randomNumber = random.Next(1, int.MaxValue);
            } while (randomNumber % 3 != 0 || randomNumber % 5 != 0);

            return randomNumber;
        }
    }
}
