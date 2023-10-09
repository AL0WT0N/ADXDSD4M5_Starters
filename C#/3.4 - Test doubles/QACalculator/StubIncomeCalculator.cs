using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QACalculator
{
    public class StubIncomeCalculator : ICalcMethod
    {
        public double Calc(Position position)
        {
            if(position == Position.NONE)
            {
                throw new ArgumentNullException();
            }
            else if(position == Position.BOSS)
            {
                return 100000;
            }
            else if (position == Position.PROGRAMMER)
            {
                return 50000;
            }
            else if (position == Position.SURFER)
            {
                return 30000;
            }
            else
            {
                throw new ArgumentException("This should not happen!");
            }
        }
    }
}
