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
    public partial class Form1 : Form
    {
        public static ArrayList ranking = new ArrayList();
        private Player player = new Player();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //Inicia el juego de tragaPerras // tragaMonedas
            player.Nombre = txtNombre.Text;
            player.Apellido = txtApellido.Text;
            player.Cartera = txtCartera.Text;
            player.Monedas = int.Parse(txtNombre.Text);
            TragaMonedas tragaMonedas = new TragaMonedas();
            tragaMonedas.obtenerJugador(player);
            tragaMonedas.Visible = true;
        }
    }
}
