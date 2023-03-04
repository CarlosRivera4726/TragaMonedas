﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Juego
{
    public class Player : Persona
    {
        private int monedas;
        private bool estado;
        private int puntos;

        public int Monedas { get => monedas; set => monedas = value; }
        public bool Estado { get => estado; set => estado = value; }

        public Player() { Estado = true; }
        public Player(int monedas, bool estado)
        {
            Monedas = monedas;
            Estado = estado;
        }

        public override string ToString()
        {
            string newLine = Environment.NewLine;
            return $"Player: {Nombre + " " +Apellido}" + newLine +
                   $"Estado: {Estado}" + newLine +
                   $"Cartera: {Cartera}" + newLine +
                   $"Monedas: {Monedas}" + newLine;
        }
    }
}
