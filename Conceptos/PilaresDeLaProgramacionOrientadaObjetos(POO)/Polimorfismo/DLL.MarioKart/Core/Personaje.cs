using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.MarioKart.Core
{
    public class Personaje
    {
        public virtual string Nombre { get; }
        public virtual void Hablar()
        {
            Console.WriteLine("Hola, soy un personaje de Mario Bros.");
        }
        public virtual void Descripcion()
        {
            Console.WriteLine("Un personaje de Mario Bros.");
        }
    }
}
