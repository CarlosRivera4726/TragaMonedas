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
        public TragaMonedas()
        {
            InitializeComponent();
        }
        public void obtenerJugador(Player p1)
        {
            this.player = p1;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1.ranking.Add(player);
        }
    }
}
