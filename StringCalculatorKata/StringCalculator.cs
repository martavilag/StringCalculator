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

            string[] numberList = numbers.Split(',');
            int result = 0;
            
            foreach (var number in numberList)
            {
                result += Int32.Parse(number);
            }
            
            return result;
        }
    }
}