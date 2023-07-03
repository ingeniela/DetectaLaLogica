using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.MarioKart.Core.PersonajesMarioBros
{
    public class Mario : Personaje
    {
        public override string Nombre => "Mario";

        public override void Hablar()
        {
            Console.WriteLine("¡It's-a me, Mario!");
        }

        public override void Descripcion()
        {
            Console.WriteLine("Soy un fontanero humano con un gran bigote y un sombrero rojo.");
        }
    }

    public class Luigi : Personaje
    {
        public override string Nombre => "Luigi";

        public override void Hablar()
        {
            Console.WriteLine("¡Hola soy el número uno, Luigi!");
        }

        public override void Descripcion()
        {
            Console.WriteLine("Soy el hermano de Mario, tengo un sombrero verde.");
        }
    }

    public class Yoshi : Personaje
    {
        public override string Nombre => "Yoshi";

        public override void Hablar()
        {
            Console.WriteLine("¡Yoshi!");
        }

        public override void Descripcion()
        {
            Console.WriteLine("Soy un dinosaurio amigable de colores brillantes con una lengua muy larga.");
        }
    }

    public class DonkeyKong : Personaje
    {
        public override string Nombre => "Donkey Kong";

        public override void Hablar()
        {
            Console.WriteLine("¡Ooo-oo-oo-oooh! ¡Oookay!");
        }

        public override void Descripcion()
        {
            Console.WriteLine("Soy un gorila grande y fuerte con una corbata roja y una gran personalidad.");
        }
    }
}