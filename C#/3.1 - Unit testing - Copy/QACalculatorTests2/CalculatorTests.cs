using NUnit.Framework;
using QACalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QACalculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        //[TestMethod()]
        //public void checkAllNumbersAreNumericTestWithValidValuesShouldNotThrowException()
        //{
        //    Calculator.checkAllNumbersAreNumeric(new string[] { "1.0", "2.1", "3.2" });
        //}
        //[TestMethod()]
        //[ExpectedException(typeof(ArgumentException))]
        //public void checkAllNumbersAreNumericTestWithInvalidValuesShouldThrowException()
        //{
        //    //Calculator calc = new Calculator();
        //    Calculator.checkAllNumbersAreNumeric(new string[] { "1.0", "2A", "3.2" });
        //}
        [Test]
        public void checkIsNumericForValidNumbers()
        {
            Assert.IsTrue(Utils.IsNumeric("111"));
            Assert.IsFalse(Utils.IsNumeric("1A"));
        }
    }
}