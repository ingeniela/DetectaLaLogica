using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.MarioKart.Core.Personajes
{
    public class Corredor : Personaje
    {
        public string[] ColoresTipicos { get; set; }
        public string Especie { get; set; }
        public string TipoDeVehiculo { get; set; }

        public Corredor(string nombre, string descripcion, string[] coloresTipicos, string especie, string tipoDeVehiculo)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            ColoresTipicos = coloresTipicos;
            Especie = especie;
            TipoDeVehiculo = tipoDeVehiculo;
        }

        public override void Moverse()
        {
            Console.WriteLine($"{Nombre} se está moviendo con rapidez por la pista");
        }

        public override void Saltar()
        {
            Console.WriteLine($"{Nombre} ha saltado con fuerza.");
        }
        public override void Hablar()
        {
            Console.WriteLine($"{Nombre} ha hablado.");
        }
        public void UsarObjeto()
        {
            Console.WriteLine($"{Nombre} ha usado un objeto aleatorio encontrado en la pista.");
        }

    }
}
