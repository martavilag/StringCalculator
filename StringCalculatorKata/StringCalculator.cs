using System;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public static int Sum(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;
            if (!numbers.Contains(","))
                return Int32.Parse(numbers);
            return Int32.Parse(numbers.Substring(0,1));
        }
    }
}