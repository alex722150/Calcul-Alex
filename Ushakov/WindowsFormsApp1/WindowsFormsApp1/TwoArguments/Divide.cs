using WindowsFormsApp1.TwoArguments;

namespace WindowsFormsApp1
{
    public class Divide : ITwoArgumentsCalculate
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument / secondArgument;
        }

    }
}
