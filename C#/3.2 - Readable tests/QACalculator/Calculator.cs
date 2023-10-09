using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QACalculator
{
    public class Calculator
    {
        public int Divide(String n1)
        {
            if (n1.Length > 0)
            {
                NewMethod1(n1);
            }
            else if(n1.Length == 0)
            {
                // if doesn't contain a comma call this
                if (!n1.Contains(","))
                    chat x = Utils.ValidSeperator(n1);    // slows down test

                foreach (String number in numbers)
                {
                    if (!Utils.IsNumeric(number))
                    {
                    }
                }

            }
            else
            {
                // something else
            }
            int result = -9999;
            char separator = ',';
            // if doesn't contain a comma call this
            if (!n1.Contains(","))
                separator = Utils.ValidSeperator(n1);    // slows down test
            String[] numbers = n1.Split(separator);
            foreach (String number in numbers)
            {
                if (!Utils.IsNumeric(number))
                {
                    return result;
                }
            }
            result = Utils.ToNumber(numbers[0]) / Utils.ToNumber(numbers[1]);
            return result;
        }

        private static void NewMethod1(string n1)
        {
            int result = -9999;
            char separator = ',';
            // if doesn't contain a comma call this
            if (!n1.Contains(","))
                separator = Utils.ValidSeperator(n1);    // slows down test
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
