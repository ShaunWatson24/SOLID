using DIP.Interfaces;

namespace DIP
{
    public class Calculator
    {
        private ICalculatorOperation _calculatorOperation { get; }

        public Calculator(ICalculatorOperation calculatorOperation)
        {
            _calculatorOperation = calculatorOperation;
        }

        public double Solve(double x, double y)
        {
            return _calculatorOperation.Calculate(x, y);
        }
    }
}
