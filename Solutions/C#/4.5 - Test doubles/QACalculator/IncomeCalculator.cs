using System;

namespace QACalculator
{
    public class IncomeCalculator
    {
        private ICalcMethod calcMethod;
        private Position position;

        public void SetCalcMethod(ICalcMethod calcMethod)
        {
            this.calcMethod = calcMethod;
        }

        public void SetPosition(Position position)
        {
            this.position = position;
        }

        public double Calc()
        {
            if (calcMethod == null)
            {
                throw new Exception("CalcMethod not yet maintained");
            }
            if (position == Position.NONE)
            {
                throw new Exception("Position not yet maintained");
            }
            return calcMethod.Calc(position);
        }
    }
}
