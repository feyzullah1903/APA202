namespace _06_InterfaceAbstraction;


class Program
    {
        static void Main()
        {
            ICalculation calc = new Calculation();

            Console.Write("1ci eded: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Emel (+, -, *, /): ");
            string op = Console.ReadLine();

            Console.Write("2ci eded: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double result = calc.Calculate(a, b, op);

            Console.WriteLine("Netice= " + result);
        }
    }



