using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TragaMonedas
{
    internal class Player : Persona
    {
        private int monedas;
        private bool estado;
        private int puntos;

        public int Monedas { get => monedas; set => monedas = value; }
        public bool Estado { get => estado; set => estado = value; }

        public Player() { }
        public Player(int monedas, bool estado)
        {
            Monedas = monedas;
            Estado = estado;
        }
    }
}
