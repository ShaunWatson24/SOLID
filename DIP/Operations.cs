using DIP.Interfaces;

namespace DIP
{
    public class Operations
    {
        public class AddCalculatorOperation : ICalculatorOperation
        {
            public double Calculate(double x, double y)
            {
                return x + y;
            }
        }

        public class MultiplyCalculatorOperation : ICalculatorOperation
        {
            public double Calculate(double x, double y)
            {
                return x * y;
            }
        }

        public class SubtractCalculatorOperation : ICalculatorOperation
        {
            public double Calculate(double x, double y)
            {
                return x - y;
            }
        }

        public class DivideCalculatorOperation : ICalculatorOperation
        {
            public double Calculate(double x, double y)
            {
                return x / y;
            }
        }
    }
}
