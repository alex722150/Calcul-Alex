
using System;
namespace WindowsFormsApp1
{
    public class Sqrt : IOneArgumentCalculate
    {
        public double Calculate(double firstArgument)
        {
         
                return Math.Sqrt(firstArgument);
            }
        }

    }


