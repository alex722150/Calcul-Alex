using System;

namespace WindowsFormsApp1
{
    public class OneArgumentFactory
    {
        public static IOneArgumentCalculate CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Squaring":
                    return new Squaring();
                case "Sqrt":
                    return new Sqrt();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
