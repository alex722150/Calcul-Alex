namespace WindowsFormsApp1.TwoArguments
{
    public class AddCalculator: ITwoArgumentsCalculate
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }

    }
}