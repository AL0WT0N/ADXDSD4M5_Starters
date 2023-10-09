using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace QACalculator
{
    public static class Utils
    {
        public static int ToNumber(String s)
        {
            return int.Parse(s);
        }

        public static bool IsNumeric(String str)
        {
            var exp = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
            bool res =  exp.IsMatch(str);
            return res;
        }

        // Example of a slow method
        public static char ValidSeperator(String s)
        {
            int index = 0;
            while (char.IsDigit(s[index]))
                index++;
            try
            {
                Thread.Sleep(1000);
            }
            catch (Exception)
            {
            }
            return s[index];
        }
    }
}
