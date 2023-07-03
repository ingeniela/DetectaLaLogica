using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.MarioKart.Core
{
    public interface IPersonaje
    {
        string Nombre { get; set; }
        string Descripcion { get; set; }
        void Moverse();
        void Saltar();
        void Hablar();
        void UsarObjeto();
    }
}