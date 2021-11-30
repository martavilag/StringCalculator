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

            var firstNumber = Int32.Parse(numbers.Substring(0,1));
            var secondNumber = Int32.Parse(numbers.Substring(2));
            
            return firstNumber + secondNumber;
        }
    }
}