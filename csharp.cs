using System;

namespace FizzBuzz
{
    public class Program
    {
        public static void FizzBuzz(int number)
        {
            var str = string.Empty;
            var fizzOrBuzz = false;
            if (number%3 == 0)
            {
                str = "Fizz";
                fizzOrBuzz = true;
            }
            else if (number%5 == 0)
            {
                str += "Buzz";
                fizzOrBuzz = true;
            }
            if (fizzOrBuzz)
            {
                Console.WriteLine(str);
            }
            else 
            {
                Console.WriteLine(number);   
            }
        }

        private static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                FizzBuzz(i);
            }
        }
    }
}
