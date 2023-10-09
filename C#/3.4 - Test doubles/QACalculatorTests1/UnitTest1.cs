using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using QACalculator;

namespace QACalculatorTests1
{
    [TestClass]
    public class UnitTest1
    {
        ICalcMethod calc;

        [TestInitialize]
        public void setup()
        {
            var moq = new Mock<ICalcMethod>();
            moq.Setup(c => c.Calc(Position.BOSS)).Returns(100000);
            moq.Setup(c => c.Calc(Position.PROGRAMMER)).Returns(50000);
            calc = moq.Object;
        }

        [TestMethod]
        public void TestCalcForProgrammer()
        {
            double res = calc.Calc(Position.PROGRAMMER);
            Assert.AreEqual(res, 50000);
        }

        [TestMethod]
        public void TestCalcForBoss()
        {
            double res = calc.Calc(Position.BOSS);
            Assert.AreEqual(res, 100000);
        }
    }
}
