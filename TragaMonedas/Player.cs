using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TragaMonedas
{
    internal class Player : Persona
    {
        private string monedas;
        private bool estado;

        public string Monedas { get => monedas; set => monedas = value; }
        public bool Estado { get => estado; set => estado = value; }

        public Player() { }
        public Player(string monedas, bool estado)
        {
            Monedas = monedas;
            Estado = estado;
        }
    }
}
