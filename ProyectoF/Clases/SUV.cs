using ProyectoF.Cosas;
using ProyectoF.Cosas;

namespace ProyectoF.Clases
{
    internal class SUV : VehiculoBase
    {
        public string Mecanico { get; set; }
        public string Seguro { get; set; }
        public string Economico { get; set; }

        private int Encendido = 0;
        public void EncenderSUV()
        {
            if (Encendido == 0)
            {
                base.Encender();
                Console.WriteLine("Se ha encendido el suv");
                Encendido = 1;
            }
        }
    }
}
