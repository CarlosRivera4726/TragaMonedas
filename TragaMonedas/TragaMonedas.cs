using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego
{
    public partial class TragaMonedas : Form
    {
        private Player player;
        private int puntuacion=0;
        public TragaMonedas()
        {
            InitializeComponent();
            this.lblDatos.Text += puntuacion;
        }
        public void obtenerJugador(Player p1)
        {
            player = p1;
            lblDatos.Text = p1.ToString();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //TODO: Se necesita cambiar ls imagenes defaul por unos gift y despues de detener la maquina
            // se coloquen imagenes de forma aleatoria y dependiendo de los resultados se dara un premio
            // o se quitara una puntuacion
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1.ranking.Add(player);
        }

       
    }
}
