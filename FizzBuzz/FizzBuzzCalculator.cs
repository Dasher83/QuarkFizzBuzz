namespace FizzBuzz
{
    public class FizzBuzzCalculator
    {
        public static string Check(int number)
        {

            if (IsFizzBuzz(number)) return "FizzBuzz";

            if (IsFizz(number)) return "Fizz";

            if (IsBuzz(number)) return "Buzz";

            return number.ToString();
        }

        private static bool IsFizzBuzz(int number)
        {
            return number % 3 == 0 && number % 5 == 0;
        }

        private static bool IsFizz(int number)
        {
            return number % 3 == 0;
        }

        private static bool IsBuzz(int number)
        {
            return number % 5 == 0;
        }
    }
}