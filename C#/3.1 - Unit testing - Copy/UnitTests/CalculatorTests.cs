using NUnit.Framework;
using QACalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Subtract_ValidString_CalculatesResult()
        {
            Calculator calc = new Calculator();
            int res = calc.Divide("4,2");
            Assert.AreEqual(res,2);
            //Assert.Fail("Not yet implemented...");
        }
    }
}
