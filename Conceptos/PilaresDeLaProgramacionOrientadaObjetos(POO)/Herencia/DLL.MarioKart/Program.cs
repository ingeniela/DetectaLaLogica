using DLL.MarioKart.Core;
using DLL.MarioKart.Core.Personajes;
using System;
using System.Collections.Generic;

namespace DLL.MarioKart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Agregamos los personajes que el usuario puede escoger
            List<Corredor> corredores = new List<Corredor>();

            Corredor mario2 = new Corredor("Mario", "Un fontanero humano con un gran bigote y un sombrero rojo.", new string[] { "Rojo", "Azul" }, "Humano", "Auto");
            corredores.Add(mario2);

            // Creamos el objeto (en este caso, un corredor)
            Corredor mario = new Corredor("Mario", "Un fontanero humano con un gran bigote y un sombrero rojo.", new string[] { "Rojo", "Azul" }, "Humano", "Auto");
            corredores.Add(mario);

            // Y podemos agregar todos los objetos sin necesidad de que tengan su propia variable
            corredores.Add(new Corredor("Luigi", "El hermano menor de Mario, con un sombrero verde y camisa verde.", new string[] { "Verde", "Azul" }, "Humano", "Bicicleta"));
            corredores.Add(new Corredor("Peach", "La princesa del Reino Champiñón, con cabello rubio y vestido rosa.", new string[] { "Rosa", "Amarillo" }, "Humana", "Planeador"));
            corredores.Add(new Corredor("Yoshi", "Un dinosaurio verde con manchas blancas, con una lengua larga y pegajosa.", new string[] { "Verde", "Blanco" }, "Dinosaurio", "Moto"));
            corredores.Add(new Corredor("Doonkey Kong", "Un gorila fuerte y musculoso, con corbata roja.", new string[] { "Marrón", "Amarillo" }, "Gorila", "Auto"));
            corredores.Add(new Corredor("Bowser", "El archienemigo de Mario, un gran dragón con caparazón de tortuga.", new string[] { "Verde", "Rojo" }, "Dinosaurio", "Kart"));

            // Mensaje de bienvenida y los personajes disponibles para el usuario
            Console.WriteLine("Bienvenido al juego de Mario Kart. ¿Con qué personaje quieres jugar?");
            for (int i = 0; i < corredores.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {corredores[i].Nombre}");
            }

            // Leemos el personaje seleccionado por el usuario desde la consola
            Console.Write("Escribe el número del personaje que quieres seleccionar: ");
            int opcionCorredor = int.Parse(Console.ReadLine());
            Corredor corredorSeleccionado = corredores[opcionCorredor - 1];

            // Mostramos las opciones disponibles para el usuario
            Console.WriteLine($"¿Qué quieres hacer con {corredorSeleccionado.Nombre}?");
            Console.WriteLine("1. Moverse \n 2. Saltar \n 3. Driftear \n 4. Usar objeto \n 5. Salir del juego");

            // Creamos un bucle do while para permitir al usuario realizar acciones con el personaje seleccionado
            int opcionAccion;
            do
            {
                // Leemos la opción seleccionada por el usuario desde la consola
                Console.Write("\n Escribe el número de la opción que quieres realizar: ");
                opcionAccion = int.Parse(Console.ReadLine());

                // Llamamos a la función correspondiente en el objeto Personaje seleccionado
                switch (opcionAccion)
                {
                    case 1:
                        corredorSeleccionado.Moverse();
                        break;
                    case 2:
                        corredorSeleccionado.Saltar();
                        break;
                    case 3:
                        corredorSeleccionado.Hablar();
                        break;
                    case 4:
                        corredorSeleccionado.UsarObjeto();
                        break;
                    case 5:
                        Console.WriteLine("¡Gracias por jugar!");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            } while (opcionAccion != 5);
        }
    }
}
