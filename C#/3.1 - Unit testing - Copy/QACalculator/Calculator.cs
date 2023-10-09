using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QACalculator
{
    public class Calculator
    {
        public int Divide(String n1)  // "10"
        {
            string[] numbers = getNumbersFromString(n1);

            return Utils.ToNumber(numbers[0]) / Utils.ToNumber(numbers[1]);
        }

        private static string[] getNumbersFromString(string n1)
        {
            char separator = getSeparator(n1);
            String[] numbers = n1.Split(separator);

            checkAllNumbersAreNumeric(numbers);  // throws ArgumentException
            return numbers;
        }
       
        public static void checkAllNumbersAreNumeric(string[] numbers)
        {
            foreach (String number in numbers)
            {
                if (!Utils.IsNumeric(number))
                {
                    throw new ArgumentException();
                }
            }
        }

        private static char getSeparator(string n1)
        {
            char separator = ',';
            // if doesn't contain a comma call this
            if (!n1.Contains(","))
                separator = Utils.ValidSeperator(n1);    // slows down test
            return separator;
        }

        public int Multiply(String n1)
        {
            int result = -9999;
            String[] numbers = n1.Split(',');
            foreach (String number in numbers)
            {
                if (!Utils.IsNumeric(number))
                {  // check number is valid
                    return result;
                }
            }
            result = Utils.ToNumber(numbers[0]) * Utils.ToNumber(numbers[1]);
            return result;
        }

        public int Subtract(String n1)
        {
            int result = -9999;

            String[] numbers = n1.Split(',');
            foreach (String number in numbers)
            {
                if (!Utils.IsNumeric(number))
                {  // check number is valid
                    return result;
                }
            }
            result = Utils.ToNumber(numbers[0]) - Utils.ToNumber(numbers[1]);
            return result;
        }
    }
}
