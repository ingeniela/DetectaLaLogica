using DLL.MarioKart.Core;
using DLL.MarioKart.Core.PersonajesMarioBros;
using System;
using System.Collections.Generic;

namespace DLL.MarioKart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido a la selección de personajes de Mario Kart!");

            // Crear instancias de cada uno de los personajes
            Personaje mario = new Mario();
            Personaje luigi = new Luigi();
            Personaje yoshi = new Yoshi();
            Personaje donkeyKong = new DonkeyKong();

            // Mostrar los nombres de los personajes disponibles
            Console.WriteLine("\nPersonajes disponibles:");
            Console.WriteLine($"1. {mario.Nombre}");
            Console.WriteLine($"2. {luigi.Nombre}");
            Console.WriteLine($"3. {yoshi.Nombre}");
            Console.WriteLine($"4. {donkeyKong.Nombre}");
            Console.WriteLine($"5. Salir");

            // Pedir al usuario que elija un personaje
            int opcion;
            do
            {
                Console.Write("\nSelecciona una opción (1-5): ");
                opcion = int.Parse(Console.ReadLine());

                Personaje personajeSeleccionado = null;
                switch (opcion)
                {
                    case 1:
                        personajeSeleccionado = mario;
                        personajeSeleccionado.Hablar();
                        personajeSeleccionado.Descripcion();
                        break;
                    case 2:
                        personajeSeleccionado = luigi;
                        personajeSeleccionado.Hablar();
                        personajeSeleccionado.Descripcion();
                        break;
                    case 3:
                        personajeSeleccionado = yoshi;
                        personajeSeleccionado.Hablar();
                        personajeSeleccionado.Descripcion();
                        break;
                    case 4:
                        personajeSeleccionado = donkeyKong;
                        personajeSeleccionado.Hablar();
                        personajeSeleccionado.Descripcion();
                        break;
                    case 5:
                        Console.WriteLine("\n¡Gracias por jugar!");
                        break;
                    default:
                        Console.WriteLine("\nOpción inválida.");
                        break;
                }

            } while (opcion != 5);
        }
    }
}
