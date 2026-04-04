namespace TiroParabolico
{
    partial class BackForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackForm));
            this.picTejo = new System.Windows.Forms.PictureBox();
            this.picObjetivo = new System.Windows.Forms.PictureBox();
            this.picObstaculo = new System.Windows.Forms.PictureBox();
            this.picSuelo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTejo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObjetivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObstaculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSuelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picTejo
            // 
            this.picTejo.BackColor = System.Drawing.Color.Transparent;
            this.picTejo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picTejo.BackgroundImage")));
            this.picTejo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTejo.Location = new System.Drawing.Point(140, 340);
            this.picTejo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picTejo.Name = "picTejo";
            this.picTejo.Size = new System.Drawing.Size(52, 54);
            this.picTejo.TabIndex = 0;
            this.picTejo.TabStop = false;
            this.picTejo.Visible = false;
            // 
            // picObjetivo
            // 
            this.picObjetivo.BackColor = System.Drawing.Color.Transparent;
            this.picObjetivo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picObjetivo.BackgroundImage")));
            this.picObjetivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picObjetivo.Location = new System.Drawing.Point(824, 453);
            this.picObjetivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picObjetivo.Name = "picObjetivo";
            this.picObjetivo.Size = new System.Drawing.Size(188, 50);
            this.picObjetivo.TabIndex = 1;
            this.picObjetivo.TabStop = false;
            this.picObjetivo.Visible = false;
            // 
            // picObstaculo
            // 
            this.picObstaculo.BackColor = System.Drawing.Color.Transparent;
            this.picObstaculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picObstaculo.Location = new System.Drawing.Point(399, 310);
            this.picObstaculo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picObstaculo.Name = "picObstaculo";
            this.picObstaculo.Size = new System.Drawing.Size(151, 193);
            this.picObstaculo.TabIndex = 2;
            this.picObstaculo.TabStop = false;
            this.picObstaculo.Visible = false;
            // 
            // picSuelo
            // 
            this.picSuelo.BackColor = System.Drawing.Color.Transparent;
            this.picSuelo.Location = new System.Drawing.Point(476, 498);
            this.picSuelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picSuelo.Name = "picSuelo";
            this.picSuelo.Size = new System.Drawing.Size(588, 41);
            this.picSuelo.TabIndex = 3;
            this.picSuelo.TabStop = false;
            this.picSuelo.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(341, 263);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 256);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picSuelo);
            this.Controls.Add(this.picObstaculo);
            this.Controls.Add(this.picObjetivo);
            this.Controls.Add(this.picTejo);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BackForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BackForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BackForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BackForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picTejo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObjetivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObstaculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSuelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picTejo;
        private System.Windows.Forms.PictureBox picObjetivo;
        private System.Windows.Forms.PictureBox picObstaculo;
        private System.Windows.Forms.PictureBox picSuelo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

