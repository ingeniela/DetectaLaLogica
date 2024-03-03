using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mostrar opciones al usuario
            Console.WriteLine("**Calculadora de @ingeniela**");
            Console.WriteLine("Seleccione una operación: +, -, *, /");

            // Leer la opción del usuario
            string opcion = Console.ReadLine();

            // Leer los números del usuario
            Console.WriteLine("Introduzca el primer número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca el segundo número:");
            double num2 = double.Parse(Console.ReadLine());

            // Realizar la operación según la opción seleccionada
            double resultado = 0;
            switch (opcion)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: No se puede dividir por 0.");
                        return;
                    }
                    resultado = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    return;
            }

            // Crear un resultado inválodo
            double resultadoInvalido = resultado + resultado*0.10;

            // Mostrar el resultado
            Console.WriteLine("El resultado es: {0} {1} {2} = {3}", num1, opcion, num2, resultadoInvalido);

            // Preguntar al usuario si la calculo fue correcta
            Console.WriteLine("¿El cálculo fue correcto? (si/no)");
            string respuesta = Console.ReadLine();

            // Mostrar un mensaje de acuerdo a la respuesta del usuario
            if (respuesta == "si")
            {
                Console.WriteLine("¡Gracias por usar la calculadora!");
            }
            else
            {
                Console.WriteLine("Bueno perdón xd ");
                string[] lines = new string[]
                {
                    "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⠛⠛⠛⠛⠛⠛⠿⠿⣿⣿⣿⣿⣿",
                    "⣿⣿⣯⡉⠉⠉⠙⢿⣿⠟⠉⠉⠉⣩⡇⠄⠄⢀⣀⣀⡀⠄⠄⠈⠹⣿⣿⣿",
                    "⣿⣿⣿⣷⣄⠄⠄⠈⠁⠄⠄⣠⣾⣿⡇⠄⠄⢸⣿⣿⣿⣷⡀⠄⠄⠘⣿⣿",
                    "⣿⣿⣿⣿⣿⣶⠄⠄⠄⠠⣾⣿⣿⣿⡇⠄⠄⢸⣿⣿⣿⣿⡇⠄⠄⠄⣿⣿",
                    "⣿⣿⣿⣿⠟⠁⠄⠄⠄⠄⠙⢿⣿⣿⡇⠄⠄⠸⠿⠿⠿⠟⠄⠄⠄⣰⣿⣿",
                    "⣿⡿⠟⠁⠄⢀⣰⣶⣄⠄⠄⠈⠻⣿⡇⠄⠄⠄⠄⠄⠄⠄⢀⣠⣾⣿⣿⣿",
                    "⣿⣷⣶⣶⣶⣿⣿⣿⣿⣷⣶⣶⣶⣿⣷⣶⣶⣶⣶⣶⣶⣿⣿⣿⣿⣿⣿⣿",
                    "⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿"
                };
    
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
