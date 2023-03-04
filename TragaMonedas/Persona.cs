using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TragaMonedas
{
    internal class Persona
    {
        private string nombre;
        private string apellido;
        private string cartera;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Cartera { get => cartera; set => cartera = value; }

        public Persona() { }
        public Persona(string nombre, string apellido, string cartera)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cartera = cartera;
        }
    }
}
