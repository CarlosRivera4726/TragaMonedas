namespace TragaMonedas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TragaMonedas));
            this.pBValue1 = new System.Windows.Forms.PictureBox();
            this.pBValue2 = new System.Windows.Forms.PictureBox();
            this.pBValue3 = new System.Windows.Forms.PictureBox();
            this.lblPuntaje = new System.Windows.Forms.Label();
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
            // TragaMonedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1019, 553);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.pBValue3);
            this.Controls.Add(this.pBValue2);
            this.Controls.Add(this.pBValue1);
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
    }
}