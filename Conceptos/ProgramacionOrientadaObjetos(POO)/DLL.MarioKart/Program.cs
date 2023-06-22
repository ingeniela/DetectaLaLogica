using DLL.MarioKart.Core;
using System;
using System.Collections.Generic;

namespace DLL.MarioKart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Agregamos los personajes que el usuario puede escoger
            List<Personaje> personajes = new List<Personaje>();

            // Creamos el objeto (en este caso, el personaje)
            Personaje mario = new Personaje
            {
                Nombre = "Mario",
                Descripcion = "Un fontanero humano con un gran bigote y un sombrero rojo.",
                ColoresTipicos = new string[] { "Rojo", "Azul" },
                Especie = "Humano"
            };
            personajes.Add(mario);

            // Y podemos agregar todos los objetos sin necesidad de que tengan su propia variable
            personajes.Add(new Personaje
            {
                Nombre = "Luigi",
                Descripcion = "El hermano menor de Mario, con un sombrero verde y camisa verde.",
                ColoresTipicos = new string[] { "Verde", "Azul" },
                Especie = "Humano"
            });
            personajes.Add(new Personaje
            {
                Nombre = "Peach",
                Descripcion = "La princesa del Reino Champiñón, con cabello rubio y vestido rosa.",
                ColoresTipicos = new string[] { "Rosa", "Amarillo" },
                Especie = "Humana"
            });
            personajes.Add(new Personaje
            {
                Nombre = "Yoshi",
                Descripcion = "Un dinosaurio verde con manchas blancas, con una lengua larga y pegajosa.",
                ColoresTipicos = new string[] { "Verde", "Blanco" },
                Especie = "Dinosaurio"
            });
            personajes.Add(new Personaje
            {
                Nombre = "Doonkey Kong",
                Descripcion = "Un gorila fuerte y musculoso, con corbata roja.",
                ColoresTipicos = new string[] { "Marrón", "Amarillo" },
                Especie = "Gorila"
            });
            personajes.Add(new Personaje
            {
                Nombre = "Bowser",
                Descripcion = "El archienemigo de Mario, un gran dragón con caparazón de tortuga.",
                ColoresTipicos = new string[] { "Verde", "Rojo" },
                Especie = "Dinosaurio"
            });

            // Mensaje de bienvenida y los personajes disponibles para el usuario
            Console.WriteLine("Bienvenido al juego de Mario Kart. ¿Con qué personaje quieres jugar?");
            for (int i = 0; i < personajes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {personajes[i].Nombre}");
            }

            // Leemos el personaje seleccionado por el usuario desde la consola
            Console.Write("Escribe el número del personaje que quieres seleccionar: ");
            int opcionPersonaje = int.Parse(Console.ReadLine());
            Personaje personajeSeleccionado = personajes[opcionPersonaje - 1];

            // Mostramos las opciones disponibles para el usuario
            Console.WriteLine($"¿Qué quieres hacer con {personajeSeleccionado.Nombre}?");
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
                        personajeSeleccionado.Moverse();
                        break;
                    case 2:
                        personajeSeleccionado.Saltar();
                        break;
                    case 3:
                        personajeSeleccionado.Driftear();
                        break;
                    case 4:
                        personajeSeleccionado.UsarObjeto();
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
