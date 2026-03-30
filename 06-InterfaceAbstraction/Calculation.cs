using System;
using System.Collections.Generic;
using System.Text;

namespace _06_InterfaceAbstraction
{
    using System;

    public class Calculation : ICalculation
    {
        public double Calculate(double a, double b, string operation)
        {
            switch (operation)
            {
                case "+":
                    return a + b;

                case "-":
                    return a - b;

                case "*":
                    return a * b;

                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("0-a bolmek olmaz!");
                        return 0;
                    }
                    return a / b;

                default:
                    Console.WriteLine("Yanlis emel!");
                    return 0;
            }
        }
    }
}
