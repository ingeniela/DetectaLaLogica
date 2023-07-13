using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.MarioKart.Core
{
    public abstract class Vehiculo
    {
        private string _tipo;
        private string _propietario;

        public Vehiculo(string tipo, string propietario)
        {
            _tipo = tipo;
            _propietario = propietario;
        }

        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public string Propietario
        {
            get { return _propietario; }
            set { _propietario = value; }
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
    }
}
