namespace FizzBuzz
{
    public class FizzBuzzCalculator
    {
        public static string Check(int number)
        {
            string result = number.ToString();

            if (number % 3 == 0) result = "Fizz";
            
            return result;
        }
    }
}