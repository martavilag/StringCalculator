using System;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public static int Sum(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;
            return Int32.Parse(numbers);
        }
    }
}