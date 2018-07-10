using System;

namespace WindowsFormsApp1.TwoArguments
{
    public class Substract : ITwoArgumentsCalculate
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }

        public object Calculate(double firstValue) => throw new NotImplementedException();
    }
}
