using ProyectoF.Cosas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoF.Clases
{
    internal class PickUp : VehiculoBase
    {
        public string Llantas { get; set; }
        public string Motor { get; set; }
        public string Radio { get; set; }
        private int Encendido = 0;
        public void Encender1()
        {
            base.Encender();
            Console.WriteLine("Bienvenido a tu vehiculo");
            Encendido = 1;
        }

        internal void Abrirventa()
        {
            throw new NotImplementedException();
        }
    }
}