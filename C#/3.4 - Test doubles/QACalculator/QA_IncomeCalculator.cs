
namespace QACalculator
{
    public class QA_IncomeCalculator : ICalcMethod
    {
        public double Calc(Position position)
        {
            // uses a database to extract income for a given position
            double income;
            income = 50000;
            return income;
            // But we don't use this class because we do not want 
            // any dependency on external system like RDMS or web service
            // Networks, File Systems...
        }
    }
}
