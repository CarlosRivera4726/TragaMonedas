using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego
{
    public partial class TragaMonedas : Form
    {
        private Player player;
        private int puntuacion=0;
        private const int VALUE_COIN = 4;
        private SoundPlayer reproductor;
        public TragaMonedas()
        {
            InitializeComponent();
            this.lblPuntaje.Text += puntuacion;
        }
        public void obtenerJugador(Player p1)
        {
            player = p1;
            lblDatos.Text = p1.ToString();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            // TODO: Se necesita cambiar ls imagenes defaul por unos gift y despues de detener la maquina
            // se coloquen imagenes de forma aleatoria y dependiendo de los resultados se dara un premio
            // o se quitara una puntuacion, por supuesto se bajaran las monedas en numeros pares hasta que haya 0, si tiene
            // en cartera se le preguntara si quiere agregar más, caso contrario se saldra de la aplicacion y terminara el juego
            btnDetener.Enabled = true;
            btnIniciar.Enabled = false;
            pBValue1.Image = Juego.Properties.Resources.init;
            pBValue2.Image = Juego.Properties.Resources.mid;
            pBValue3.Image = Juego.Properties.Resources.last;
            // TODO: reproductor de sonido

            /*
             * System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
             * player.Play();
             * 
             */
            reproductor = new SoundPlayer(@"E:\source\repos\TragaMonedas\TragaMonedas\resources\sonido.wav");
            reproductor.Play();
            if (player.Monedas > 0)
            {
                player.Monedas -= VALUE_COIN;
                lblDatos.Text = player.ToString();
            }
            else
            {
                if (player.Cartera > 0)
                {

                    var options = MessageBox.Show("Debes agregar más monedas, se descontara la mitad de tu cartera, deseas hacerlo?", "Peticion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (options == DialogResult.Yes)
                    {
                        // le damos la mitad
                        player.Monedas = player.Cartera/2;
                    }
                    else
                    {
                        MessageBox.Show("Lo sentimos, no puedes continuar jugando");
                        btnIniciar.Enabled = false;
                        btnDetener.Enabled = false;
                    }

                }
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1.ranking.Add(player);
            reproductor.Stop();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            // el resultado y vamos a cambiar a los estaticos de forma aleatoria
            // desde el 1 al 6 van a estar los estaticos
            btnDetener.Enabled = false;
            btnIniciar.Enabled = true;
            reproductor.Stop();
            Random rnd = new Random();
            // valores de .Next(), minimo incluido, maximo excluido, como vamos de 
            // 1 hasta 6 sumamos uno
            int init = rnd.Next(1, 7);
            int mid = rnd.Next(1, 7);
            int last = rnd.Next(1, 7);

            pBValue1.Image = imageList2.Images[init];
            pBValue2.Image = imageList2.Images[mid];
            pBValue3.Image = imageList2.Images[last];
            // TODO: resolver las condicionales XD

            if (init == mid && init == last && mid == last)
            {
                puntuacion += 15;
            }
            else if (init == mid || init == last || mid == last)
            {
                puntuacion += 5;
            }
            else if (init != mid && init != last && mid != last)
            {
                MessageBox.Show("No ganaste ningun punto", ":(", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            lblPuntaje.Text = $"Puntaje: {puntuacion}";
            
        }
    }
}
