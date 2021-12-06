using System;
using System.Linq;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;
            if (!numbers.Contains(","))
                return Int32.Parse(numbers);

            string[] numberList = numbers.Split(',');
            return numberList.Sum(n => Int32.Parse(n));
            
        }
    }
}