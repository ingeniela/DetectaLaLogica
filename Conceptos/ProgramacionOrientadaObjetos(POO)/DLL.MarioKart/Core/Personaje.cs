using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.MarioKart.Core
{
    public class Personaje
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string[] ColoresTipicos { get; set; }
        public string Especie { get; set; }

        public void Moverse()
        {
            Console.WriteLine($"{Nombre} se está moviendo.");
        }

        public void Saltar()
        {
            Console.WriteLine($"{Nombre} ha saltado.");
        }

        public void Driftear()
        {
            Console.WriteLine($"{Nombre} está drifteando.");
        }

        public void UsarObjeto()
        {
            Console.WriteLine($"{Nombre} ha usado un objeto.");
        }
    }
}
