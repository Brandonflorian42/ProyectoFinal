using ProyectoF.Cosas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoF.Clases
{
    internal class Sedan : VehiculoBase
    {
        public string Gabinete { get; set; }
        public string Sillones { get; set; }
        public string Aceite { get; set; }
        private int Encendido = 0;
        public void EncenderSedan()
        {
            if (Encendido == 0)
            {
                base.Encender();
                Console.WriteLine("El sedan se ha encendido");
                Encendido = 1;
            }
            else
            {
                Console.WriteLine("El sedan esta apagado");
            }
        }
        public void Abrirbaul()
        {
            Console.WriteLine("Abir baul");
        }
        public void Cerrarbaul()
        {
            Console.WriteLine("Cerrar bahul");
        }
    }
}
