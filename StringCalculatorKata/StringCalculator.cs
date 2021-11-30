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

            int commaIndex = numbers.IndexOf(",");

            int firstNumber = Int32.Parse(numbers.Substring(0, commaIndex));
            int secondNumber = Int32.Parse(numbers.Substring(commaIndex+1));

            int result = firstNumber + secondNumber;
            
            return result;
        }
    }
}