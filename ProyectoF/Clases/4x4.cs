using ProyectoF.Cosas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoF.Clases
{
    internal class _4x4 : VehiculoBase
    {
        private string Hermoso { get; set; }
        private string Comodo { get; set; }
        private string Caro { get; set; }
        private int Encendido = 0;
        public void Encender4x4()
        {
            if (Encendido == 0)
            {
                base.Encender();
                Console.WriteLine("El 4x4 se ha encendido");
            }
        }
    }
}