namespace WindowsFormsApp1.TwoArguments
{
    public class Multiplay: ITwoArgumentsCalculate
    {
       public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }

    }
}
