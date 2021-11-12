using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculation.Controllers
{
    public static class Calculate
    {
        public static string add(int num1, int num2)
        {
            string equation = num1.ToString() + " + " + num2.ToString() + " = ";
            return equation + (num1 + num2).ToString();
        }

        public static string Subtraction(int num1, int num2)
        {
            string equation = num1.ToString() + " - " + num2.ToString() + " = ";
            return equation + (num1 - num2).ToString();
        }

        public static string multiple(int num1, int num2)
        {
            string equation = num1.ToString() + " * " + num2.ToString() + " = ";
            return equation + (num1 * num2).ToString();
        }

        public static string Division(int num1, int num2)
        {
            string equation = num1.ToString() + " / " + num2.ToString() + " = ";
            return equation + (num1 / num2).ToString();
        }

    }
}
