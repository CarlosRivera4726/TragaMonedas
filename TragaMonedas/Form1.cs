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
            // Manejamos excepciones para verificar algunos datos
            try
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                int cartera = int.Parse(txtCartera.Text);
                int monedas = int.Parse(txtMonedas.Text);

                if (nombre.Length > 3)
                {
                    player.Nombre = nombre;
                }
                else
                {
                    throw new Exception("No has ingresado un nombre correcto!");
                }

                if (apellido.Length > 3)
                {
                    player.Apellido = apellido;
                }
                else
                {
                    throw new Exception("No has ingresado un apellido correcto!");
                }
                if (cartera > 0 && cartera < 300000)
                {
                    player.Cartera = cartera;
                }
                else
                {
                    throw new Exception("No has ingresado un valor de cartera correcto!");
                }

                if (monedas > 0 && monedas < cartera)
                {
                    // realizado: Cuantas monedas quiere agregar
                    // dependiendo del monto en cartera se puede hacer la transferencia
                    player.Monedas = monedas;
                    // restamos las monedas de la cartera
                    player.Cartera -= monedas;
                }
                else
                {
                    throw new Exception("No has ingresado un valor de monedas correcto! (monedas tiene que ser mayor a 0 y menor que tu cartera)");
                }

                TragaMonedas tragaMonedas = new TragaMonedas();
                tragaMonedas.obtenerJugador(player);
                tragaMonedas.Visible = true;
            }catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        
    }
}
