using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int cartera;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Cartera { get => cartera; set => cartera = value; }

        public Persona() { }
        public Persona(string nombre, string apellido, int cartera)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cartera = cartera;
        }
    }
}
