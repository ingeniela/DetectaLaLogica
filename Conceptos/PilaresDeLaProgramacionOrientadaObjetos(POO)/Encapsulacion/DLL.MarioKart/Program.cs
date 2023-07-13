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
            Moto moto = new Moto("Motocicleta", "Luigi");
            
            moto.Tipo = "MotoKart";
            moto.Propietario = "Waluigi";
            //moto.VelocidadMaxima = 400;

            Console.WriteLine($"\n La {moto.Tipo} de {moto.Propietario} tiene una velocidad máxima de {moto.VelocidadMaxima} km/h.");

            moto.Acelerar();
            moto.Frenar();
            moto.Girar();
            moto.HacerCaballito();

            Auto auto = new Auto("Automóvil", "Mario");
            Console.WriteLine($"\n El {auto.Tipo} de {auto.Propietario} tiene una velocidad máxima de {auto.VelocidadMaxima} km/h.");
            auto.Acelerar();
            auto.Frenar();
            auto.Girar();
            auto.TocarClaxon();
            //auto.VelocidadMaxima = 400;

            Submarino submarino = new Submarino("Submarino", "Yoshi");
            Console.WriteLine($"\n El {submarino.Tipo} de {submarino.Propietario} puede sumergirse hasta los" +
                $"{submarino.ProfundidadMaxima} metros y tiene una velocidad máxima de {submarino.VelocidadMaxima} km/h.");
            submarino.Acelerar();
            submarino.Frenar();
            submarino.Girar();
            submarino.Sumergir();

            Avion avion = new Avion("Avión", "Toad");
            Console.WriteLine($"\n El {avion.Tipo} de {avion.Propietario} puede volar hasta los {avion.AltitudMaxima} metros y tiene una velocidad máxima de {avion.VelocidadMaxima} km/h.");
            avion.Acelerar();
            avion.Frenar();
            avion.Girar();
            avion.Despegar();
        }
    }
}
