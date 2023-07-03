using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.MarioKart.Core
{
    public abstract class Personaje
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public abstract void Moverse();
        public abstract void Saltar();
        public abstract void Hablar();
    }
}
