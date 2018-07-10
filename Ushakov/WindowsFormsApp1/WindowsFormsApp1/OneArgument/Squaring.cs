namespace WindowsFormsApp1
{
    public class Squaring : IOneArgumentCalculate
    {
        public double Calculate(double firstArgument)
        {
            return firstArgument * firstArgument;
        }

    }
}
