using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Motocicleta : Vehiculo
    {
        private int nivelGasolina;
        private int kilometraje;
        private bool encendida;

        public Motocicleta(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            nivelGasolina = 15;
            encendida = false;
        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto + 12);
            nivelGasolina--;
        }

        public override void frenar(int cuanto)
        {
            base.frenar(cuanto - 8);
            nivelGasolina--;
        }

        public int NivelGasolina
        {
            get { return nivelGasolina; }
            private set
            {
                if (value < 0) nivelGasolina = 0;
                else if (value > 25) nivelGasolina = 25; // Máximo de 15L
                else nivelGasolina = value;
            }
        }

        public int nivelKilometraje() { return kilometraje; } //Metodo que regresa el nivel de kilometraje.
        public void recorrido(int cuanto)
        {
            kilometraje += cuanto;
        }

        public bool Encendida // Propiedad que regresa si la motocicleta esta encendida.
        {
            get { return encendida; }
            private set { encendida = value; }
        }
        // Métodos para encender y apagar la motocicleta
        public void Encender()
        {
            Encendida = true;
        }

        public void Apagar()
        {
            Encendida = false;
        }

    }
}