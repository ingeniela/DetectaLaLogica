using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.MarioKart.Core.VehiculosMarioBros
{
    public class Moto : Vehiculo
    {
        private int _velocidadMaxima;

        public Moto(string tipo, string propietario) : base(tipo, propietario)
        {
            _velocidadMaxima = 200;
        }

        public int VelocidadMaxima
        {
            get { return _velocidadMaxima; }
            private set { _velocidadMaxima = 200; }
        }

        public void HacerCaballito()
        {
            Console.WriteLine($"La moto está haciendo un caballito.");
        }
    }

    public class Auto : Vehiculo
    {
        private int _velocidadMaxima;

        public Auto(string tipo, string propietario) : base(tipo, propietario)
        {
            _velocidadMaxima = 205;
        }

        public int VelocidadMaxima
        {
            get { return _velocidadMaxima; }
            private set { _velocidadMaxima = 205; }
        }

        public void TocarClaxon()
        {
            Console.WriteLine($"El auto está sonando pi pi pi.");
        }
    }

    public class Submarino : Vehiculo
    {
        private int _profundidadMaxima;
        private int _velocidadMaxima;

        public Submarino(string tipo, string propietario) : base(tipo, propietario)
        {
            _profundidadMaxima = 500;
            _velocidadMaxima = 199;
        }

        public int ProfundidadMaxima
        {
            get { return _profundidadMaxima; }
            set { _profundidadMaxima = value; }
        }

        public int VelocidadMaxima
        {
            get { return _velocidadMaxima; }
            private set { _velocidadMaxima = 199; }
        }

        public void Sumergir()
        {
            Console.WriteLine($"El submarino se está sumergiendo");
        }
    }

    public class Avion : Vehiculo
    {
        private int _altitudMaxima;
        private int _velocidadMaxima;

        public Avion(string tipo, string propietario) : base(tipo, propietario)
        {
            _altitudMaxima = 10000;
            _velocidadMaxima = 210;
        }

        public int AltitudMaxima
        {
            get { return _altitudMaxima; }
            set { _altitudMaxima = value; }
        }

        public int VelocidadMaxima
        {
            get { return _velocidadMaxima; }
            private set { _velocidadMaxima = 210; }
        }

        public void Despegar()
        {
            Console.WriteLine($"El avión está despegando.");
        }
    }
}