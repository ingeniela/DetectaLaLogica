using System;

namespace DLL.Csharp.Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora #DetectaLaLógica");

            Console.WriteLine("Ingrese el primer número:");
            int num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            int num2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ingrese un signo de operación (+, -, *, /):");
            string op = Console.ReadLine();

            if (op == "+")
            {
                int result = num1 + num2;
                Console.WriteLine(result);
            }
            else if (op == "-")
            {
                int result = num1 - num2;
                Console.WriteLine(result);
            }
            else if (op == "*")
            {
                int result = num1 * num2;
                Console.WriteLine(result);
            }
            else if (op == "/")
            {
                int result = num1 / num2;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Operación inválida");
            }

            Console.ReadKey();
        }
    }
}
