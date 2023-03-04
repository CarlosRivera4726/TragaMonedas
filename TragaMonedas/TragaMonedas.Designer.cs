namespace Juego
{
    partial class TragaMonedas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TragaMonedas));
            this.pBValue1 = new System.Windows.Forms.PictureBox();
            this.pBValue2 = new System.Windows.Forms.PictureBox();
            this.pBValue3 = new System.Windows.Forms.PictureBox();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblDatos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBValue1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBValue2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBValue3)).BeginInit();
            this.SuspendLayout();
            // 
            // pBValue1
            // 
            this.pBValue1.Image = ((System.Drawing.Image)(resources.GetObject("pBValue1.Image")));
            this.pBValue1.Location = new System.Drawing.Point(197, 233);
            this.pBValue1.Name = "pBValue1";
            this.pBValue1.Size = new System.Drawing.Size(147, 155);
            this.pBValue1.TabIndex = 0;
            this.pBValue1.TabStop = false;
            // 
            // pBValue2
            // 
            this.pBValue2.Image = ((System.Drawing.Image)(resources.GetObject("pBValue2.Image")));
            this.pBValue2.Location = new System.Drawing.Point(391, 233);
            this.pBValue2.Name = "pBValue2";
            this.pBValue2.Size = new System.Drawing.Size(147, 155);
            this.pBValue2.TabIndex = 1;
            this.pBValue2.TabStop = false;
            // 
            // pBValue3
            // 
            this.pBValue3.Image = ((System.Drawing.Image)(resources.GetObject("pBValue3.Image")));
            this.pBValue3.Location = new System.Drawing.Point(578, 233);
            this.pBValue3.Name = "pBValue3";
            this.pBValue3.Size = new System.Drawing.Size(148, 155);
            this.pBValue3.TabIndex = 2;
            this.pBValue3.TabStop = false;
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntaje.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPuntaje.Location = new System.Drawing.Point(796, 9);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(80, 20);
            this.lblPuntaje.TabIndex = 3;
            this.lblPuntaje.Text = "Puntaje: ";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(884, 233);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(103, 62);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.ImageIndex = 0;
            this.btnSalir.ImageList = this.imageList1;
            this.btnSalir.Location = new System.Drawing.Point(884, 318);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 61);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Salir.png");
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(28, 17);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(35, 13);
            this.lblDatos.TabIndex = 6;
            this.lblDatos.Text = "label1";
            // 
            // TragaMonedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1019, 553);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.pBValue3);
            this.Controls.Add(this.pBValue2);
            this.Controls.Add(this.pBValue1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TragaMonedas";
            this.Text = "TragaMonedas";
            ((System.ComponentModel.ISupportInitialize)(this.pBValue1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBValue2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBValue3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBValue1;
        private System.Windows.Forms.PictureBox pBValue2;
        private System.Windows.Forms.PictureBox pBValue3;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblDatos;
    }
}