using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.MarioKart.Core
{
    public class Vehiculo
    {
        public string Tipo { get; set; }
        public string Propietario { get; set; }
        public Vehiculo(string tipo, string propietario)
        {
            Tipo = tipo;
            Propietario = propietario;
        }

        public void Acelerar()
        {
            Console.WriteLine($"{Tipo} de {Propietario} está acelerando.");
        }

        public void Frenar()
        {
            Console.WriteLine($"{Tipo} de {Propietario} está frenando.");
        }

        public void Girar()
        {
            Console.WriteLine($"{Tipo} de {Propietario} está girando.");
        }
        public void Saltar()
        {
            Console.WriteLine($"{Tipo} de {Propietario} está saltando.");
        }
    }
}
