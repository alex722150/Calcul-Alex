using System;

namespace WindowsFormsApp1.TwoArguments
{
    public static class TwoArgumentFactory
    {
        public static ITwoArgumentsCalculate CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Add":
                    return new AddCalculator();
                case "Substract":
                    return new Substract();
                case "Divide":
                    return new Divide();
                case "Multiply":
                    return new Multiplay();
               

                default:
                    throw new Exception("Неизвестная операция");

            }

        }
    }
}
