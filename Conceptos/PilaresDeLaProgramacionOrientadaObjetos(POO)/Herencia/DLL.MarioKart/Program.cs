using DLL.MarioKart.Core;
using DLL.MarioKart.Core.VehiculosMarioBros;
using System;
using System.Collections.Generic;

namespace DLL.MarioKart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Moto moto = new Moto("Motocicleta", "Luigi", 200);
            Console.WriteLine($"\n La {moto.Tipo} de {moto.Propietario} tiene una velocidad máxima de {moto.VelocidadMaxima} km/h.");
            moto.Acelerar();
            moto.Frenar();
            moto.Girar();
            moto.HacerCaballito();
            moto.Saltar();

            Auto auto = new Auto("Automóvil", "Mario", 205);
            Console.WriteLine($"\n El {auto.Tipo} de {auto.Propietario} tiene una velocidad máxima de {auto.VelocidadMaxima} km/h.");
            auto.Acelerar();
            auto.Frenar();
            auto.Girar();
            auto.TocarClaxon();

            Submarino submarino = new Submarino("Submarino", "Yoshi", 500, 50);
            Console.WriteLine($"\n El {submarino.Tipo} de {submarino.Propietario} puede sumergirse hasta los" +
                $"{submarino.ProfundidadMaxima} metros y tiene una velocidad máxima de {submarino.VelocidadMaxima} km/h.");
            submarino.Acelerar();
            submarino.Frenar();
            submarino.Girar();
            submarino.Sumergir();

            Avion avion = new Avion("Avión", "Donkey Kong", 10000, 800);
            Console.WriteLine($"\n El {avion.Tipo} de {avion.Propietario} puede elevarse hasta los" +
                $"{avion.AltitudMaxima} metros y tiene una velocidad máxima de {avion.VelocidadMaxima} km/h.");
            avion.Acelerar();
            avion.Frenar();
            avion.Girar();
            avion.Despegar();
        }
    }
}
