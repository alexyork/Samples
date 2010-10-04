using System;

namespace CleanCode
{
    public class FizzBuzz
    {
        public string GetResult(int theNumber)
        {
            if (theNumber.IsMultipleOfThreeAndFive())
                return "FizzBuzz";

            if (theNumber.IsMultipleOfThree())
                return "Fizz";

            if (theNumber.IsMultipleOfFive())
                return "Buzz";

            return theNumber.ToString();
        }
    }

    public static class Extensions
    {
        public static bool IsMultipleOfThreeAndFive(this int number)
        {
            return number.IsMultipleOfThree() && number.IsMultipleOfFive();
        }

        public static bool IsMultipleOfThree(this int number)
        {
            return number % 3 == 0;
        }

        public static bool IsMultipleOfFive(this int number)
        {
            return number % 5 == 0;
        } 
    }
}



































    //public class FizzBuzz
    //{
    //    public string Print(int number)
    //    {
    //        if (number.IsMultipleOfThree() && number.IsMultipleOfFive())
    //            return "FizzBuzz";

    //        if (number.IsMultipleOfThree())
    //            return "Fizz";

    //        if (number.IsMultipleOfFive())
    //            return "Buzz";

    //        return number.ToString();
    //    }
    //}

    //public static class IntegerExtensions
    //{
    //    public static bool IsMultipleOfThree(this int numberToTest)
    //    {
    //        return numberToTest % 3 == 0;
    //    }

    //    public static bool IsMultipleOfFive(this int numberToTest)
    //    {
    //        return numberToTest % 5 == 0;
    //    }
    //}
