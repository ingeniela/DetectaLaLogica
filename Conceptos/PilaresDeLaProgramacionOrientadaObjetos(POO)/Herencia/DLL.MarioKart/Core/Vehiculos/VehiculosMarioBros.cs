using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.MarioKart.Core.VehiculosMarioBros
{
    public class Moto : Vehiculo
    {
        public int VelocidadMaxima { get; set; }
        
        public Moto(string tipo, string propietario, int velocidadMaxima) : base(tipo, propietario)
        {
            VelocidadMaxima = velocidadMaxima;
          
        }
        public void HacerCaballito()
        {
            Console.WriteLine($"La moto está haciendo un caballito.");
        }
    }
    public class Auto : Vehiculo
    {
        public int VelocidadMaxima { get; set; }

        public Auto(string tipo, string propietario, int velocidadMaxima) : base(tipo, propietario)
        {
            VelocidadMaxima = velocidadMaxima;
        }

        public void TocarClaxon()
        {
            Console.WriteLine($"El auto está sonando pi pi pi.");
        }
    }
    public class Submarino : Vehiculo
    {
        public int ProfundidadMaxima { get; set; }
        public int VelocidadMaxima { get; set; }

        public Submarino(string tipo, string propietario, int profundidadMaxima, int velocidadMaxima) : base(tipo, propietario)
        {
            ProfundidadMaxima = profundidadMaxima;
            VelocidadMaxima = velocidadMaxima;
        }

        public void Sumergir()
        {
            Console.WriteLine($"El submarino se está sumergiendo");
        }
    }
    public class Avion : Vehiculo
    {
        public int AltitudMaxima { get; set; }
        public int VelocidadMaxima { get; set; }

        public Avion(string tipo, string propietario, int altitudMaxima, int velocidadMaxima) : base(tipo, propietario)
        {
            AltitudMaxima = altitudMaxima;
            VelocidadMaxima = velocidadMaxima;
        }
        public void Despegar()
        {
            Console.WriteLine($"El avión está despegando.");
        }
    }

}