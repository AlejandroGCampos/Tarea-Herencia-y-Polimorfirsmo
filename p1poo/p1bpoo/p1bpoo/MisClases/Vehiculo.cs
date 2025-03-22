using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get;  }
        public int Year { get;  }

        private int velocidad = 0;


        public Vehiculo(int anio, string elColor, string elModelo)
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = anio;
        }

        public void InformacionVehiculo()
        {
            Console.WriteLine("Color {0}:", this.Color);
            Console.WriteLine("Modelo {0}:", this.Modelo);
            Console.WriteLine("Año {0}", this.Year);
        }
        public virtual void acelerar(int cuanto)
        {
            velocidad += cuanto;
            Console.WriteLine("vas a {0} KMS / Hora",velocidad);
        }

        //Metodos añadidos para la clase Vehiculo
        public virtual void frenar(int cuanto) //Un metodo virtual que le dice al vehiculo que frene o disminuya la velocidad.
        {
            velocidad -= cuanto;
            Console.WriteLine("vas a {0} KMS / Hora", velocidad);
        }

        public virtual void apagar() //Un metodo virtual que le dice al vehiculo que se apague.
        {
            velocidad = 0;
            Console.WriteLine("El vehiculo esta apagado");
        }

        public virtual void encender() //Un metodo virtual que le dice al vehiculo que se encienda.
        {
            velocidad = 0;
            Console.WriteLine("El vehiculo esta encendido");
        }
    }
}
