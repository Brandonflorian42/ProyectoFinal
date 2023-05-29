//programa principal
using System;
using ProyectoF.Clases;
using ProyectoF.Cosas;
using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace ProyectoF
{
    public partial class MainPage : ContentPage
    {
        int Encendido = 0;
        int Encendido1 = 0;

        private VehiculoBase Carro1;
        private PickUp one;
        private int velocidadactual;
        private object velocidadActual;

        public MainPage()
        {
            InitializeComponent();

            Carro1 = new VehiculoBase();
            one = new PickUp();
            propiedades();
        }
        private void propiedades()
        {
            Carro1.Marca = "Marca:Toyota";
            Carro1.Modelo = "Modelo:Tacoma";
            Carro1.Color =  "Color:Negro";
            Carro1.Anio =       2023;
            Carro1.Placa = "Placa:P154FCA";
            Carro1.Tipo = "Tipo:Automatico";
            Marca.Text = Carro1.Marca;
            Modelo.Text = Carro1.Modelo;
            Color.Text = Carro1.Color;
            Anio.Text = Carro1.Anio.ToString();
            Placa.Text = Carro1.Placa;
            Tipo.Text = Carro1.Tipo;
            
        }
        private void Bocinas_Clicked(object sender, EventArgs e)
        {
            Carro1.Bocina();
            if (Encendido == 1)
            {
                Fua.Text = "Pip Pip";
            }
            else
            {
                Fua.Text = "...";
            }
        }
        private void EncenderAutomovil_Clicked(object sender, EventArgs e)
        {
            Carro1.Encender();
            if (Encendido == 0)
            {
                Fua.Text = "El automóvil se ha encendido.";
                Encendido = 1;
            }
            else
            { Fua.Text = "El automovil ya esta encendido"; }
        }

        private async void AcelerarAutomovil_Clicked(object sender, EventArgs e)
        {
            int velocidad = 0;
            int incremento = 1;

            if (Encendido == 1)
            {
                while (velocidad < 21)
                {
                    velocidad += incremento;
                    Carro1.Acelerar(velocidad);
                    Fua.Text = $"El automóvil está acelerando a {velocidad} km/h.";

                    // Agrega un retraso de tiempo para crear la sensación de aceleración gradual
                    await Task.Delay(100); // Pausa de 1 segundo
                }
            }
            else
            {
                Fua.Text = "El auto tiene que estar encendido para poder acelerar";
            }
        }

        private void Apagar_Cliked(object sender, EventArgs e)
        {
            Carro1.Apagar();
            if (Encendido == 1)
            {
                Fua.Text = "El automóvil se ha apagado.";
                Encendido = 0;
            }
            else
            { Fua.Text = "El automovil ya esta apagado"; }
        }
        private void Frenar_Clicked(object sender, EventArgs e)
        {
            int fuerzaFrenado = 5; // Valor predeterminado
            if (Encendido == 1)
            {
                velocidadactual -= fuerzaFrenado;
                Fua.Text = $"Freno con una fuerza de {fuerzaFrenado}. Velocidad actual: {velocidadActual}";
            }
            else
            {
                Fua.Text = $"Freno con una fuerza de {fuerzaFrenado} (carro apagado)";
            }
        }
    }
    
}