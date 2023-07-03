using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.MarioKart.Core.Personajes
{
    public class Corredor : IPersonaje
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
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

        public void Moverse()
        {
            Console.WriteLine($"{Nombre} se está moviendo con rapidez por la pista");
        }

        public void Saltar()
        {
            Console.WriteLine($"{Nombre} ha saltado con fuerza.");
        }

        public void Hablar()
        {
            Console.WriteLine($"{Nombre} ha hablado.");
        }
        public void UsarObjeto()
        {
            Console.WriteLine($"{Nombre} ha usado un objeto.");
        }
    }
}
