using Microsoft.VisualStudio.TestTools.UnitTesting;
using QACalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QACalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        Calculator calculator;

        [TestInitialize]
        public void setup()
        {
            calculator = new Calculator();
        }

        public void tearDown()
        {
            calculator = null;
        }

        [TestMethod]
        public void subtractTest()
        {
            int expected = 2;
            int actual = calculator.Subtract("5,3");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void subtract2Test()
        {
            int expected = -8;
            int actual = calculator.Subtract("-5,3");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void subtract3Test()
        {
            int expected = 2;
            int actual = calculator.Subtract("4,2");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void divide()
        {
            int expected = 5;
            int actual = calculator.Divide("10,2");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void divide2()
        {
            int expected = -5;
            int actual = calculator.Divide("10,-2");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void multiply()
        {
            int expected = 50;
            int actual = calculator.Multiply("25,2");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void multiply2()
        {
            int expected = 600;
            int actual = calculator.Multiply("150,4");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void dividewithsomeexception()
        {
            calculator.Divide("10,0"));
        }

    }
}