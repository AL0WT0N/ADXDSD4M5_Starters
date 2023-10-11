using System;
using FakeItEasy;
using NUnit.Framework;
using QACalculator;

namespace QACalculatorTests
{
    class IncomeCalculatorTests
    {
        private ICalcMethod calcMethod;
        private IncomeCalculator calc;

        [SetUp]
        public void SetUp()
        {
            // Make a fake implementation of ICalcMethod which returns default values
            calcMethod = A.Fake<ICalcMethod>();

            // Make an instance of the real class under test
		    calc = new IncomeCalculator();
        }

        [Test]
        public void TestCalc1()
        {
            // Configure the ICalcMethod to behave how we want
            A.CallTo(() => calcMethod.Calc(Position.BOSS)).Returns(70000.0);
            A.CallTo(() => calcMethod.Calc(Position.PROGRAMMER)).Returns(50000.0);

            // Set the calc method
            calc.SetCalcMethod(calcMethod);

            calc.SetPosition(Position.BOSS);
            double income1 = calc.Calc();
            Assert.AreEqual(70000.0, income1);

            double income2 = calc.Calc();
            Assert.AreEqual(70000.0, income2);

            calc.SetPosition(Position.PROGRAMMER);
            double income3 = calc.Calc();
            Assert.AreEqual(50000.0, income3);

            // Verify that the ICalcMethod.Calc method was called the right number of times
            A.CallTo(() => calcMethod.Calc(Position.BOSS)).MustHaveHappened(2, Times.Exactly);
            A.CallTo(() => calcMethod.Calc(Position.PROGRAMMER)).MustHaveHappenedOnceExactly();
        }

        [Test]
	    public void TestNoCalc()
        {
            // Set the position
            calc.SetPosition(Position.SURFER);

            // Calling Calc before setting the CalcMethod should throw exception
            Assert.Throws<Exception>(() => calc.Calc(), "CalcMethod not yet maintained");
        }

        [Test]
        public void TestNoPosition()
        {
            // Set the calc method
            calc.SetCalcMethod(calcMethod);

            // Calling Calc before setting the position should throw exception
            Assert.Throws<Exception>(() => calc.Calc(), "Position not yet maintained");
        }

        [Test]
	    public void TestCalc2()
        {
            // Set up a fake ICalcMethod which throws an exception
            // when asked for the income of a SURFER
            A.CallTo(() => calcMethod.Calc(Position.SURFER)).Throws(new Exception("Don't know this guy!"));

            // Set up the calc method and position
            calc.SetCalcMethod(calcMethod);
            calc.SetPosition(Position.SURFER);

            // If the ICalcMethod.calc method throws an exception, then it should
            // continue to bubble up out fo the IncomeCalculator.Calc method
            Assert.Throws<Exception>(() => calc.Calc(), "Don't know this guy!");
        }
    }
}
