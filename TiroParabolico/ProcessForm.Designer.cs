namespace TiroParabolico
{
    partial class ProcessForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessForm));
            this.picSueloF = new System.Windows.Forms.PictureBox();
            this.picObstaculoF = new System.Windows.Forms.PictureBox();
            this.picObjetivoF = new System.Windows.Forms.PictureBox();
            this.picTejoF = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnGraficas_Click = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSueloF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObstaculoF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObjetivoF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTejoF)).BeginInit();
            this.SuspendLayout();
            // 
            // picSueloF
            // 
            this.picSueloF.BackColor = System.Drawing.Color.Transparent;
            this.picSueloF.Location = new System.Drawing.Point(473, 15);
            this.picSueloF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picSueloF.Name = "picSueloF";
            this.picSueloF.Size = new System.Drawing.Size(129, 118);
            this.picSueloF.TabIndex = 7;
            this.picSueloF.TabStop = false;
            this.picSueloF.Click += new System.EventHandler(this.picSueloF_Click);
            // 
            // picObstaculoF
            // 
            this.picObstaculoF.BackColor = System.Drawing.Color.Transparent;
            this.picObstaculoF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picObstaculoF.BackgroundImage")));
            this.picObstaculoF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picObstaculoF.Location = new System.Drawing.Point(47, 15);
            this.picObstaculoF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picObstaculoF.Name = "picObstaculoF";
            this.picObstaculoF.Size = new System.Drawing.Size(141, 118);
            this.picObstaculoF.TabIndex = 6;
            this.picObstaculoF.TabStop = false;
            // 
            // picObjetivoF
            // 
            this.picObjetivoF.BackColor = System.Drawing.Color.Transparent;
            this.picObjetivoF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picObjetivoF.BackgroundImage")));
            this.picObjetivoF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picObjetivoF.Location = new System.Drawing.Point(343, 15);
            this.picObjetivoF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picObjetivoF.Name = "picObjetivoF";
            this.picObjetivoF.Size = new System.Drawing.Size(123, 118);
            this.picObjetivoF.TabIndex = 5;
            this.picObjetivoF.TabStop = false;
            this.picObjetivoF.Click += new System.EventHandler(this.picObjetivoF_Click);
            // 
            // picTejoF
            // 
            this.picTejoF.BackColor = System.Drawing.Color.Transparent;
            this.picTejoF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picTejoF.BackgroundImage")));
            this.picTejoF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTejoF.Location = new System.Drawing.Point(196, 15);
            this.picTejoF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picTejoF.Name = "picTejoF";
            this.picTejoF.Size = new System.Drawing.Size(139, 118);
            this.picTejoF.TabIndex = 4;
            this.picTejoF.TabStop = false;
            this.picTejoF.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picTejoF_MouseDown);
            this.picTejoF.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picTejoF_MouseMove_1);
            this.picTejoF.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picTejoF_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(865, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 58);
            this.button1.TabIndex = 8;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGraficas_Click
            // 
            this.btnGraficas_Click.Location = new System.Drawing.Point(688, 23);
            this.btnGraficas_Click.Margin = new System.Windows.Forms.Padding(4);
            this.btnGraficas_Click.Name = "btnGraficas_Click";
            this.btnGraficas_Click.Size = new System.Drawing.Size(169, 58);
            this.btnGraficas_Click.TabIndex = 9;
            this.btnGraficas_Click.Text = "Ver Graficas";
            this.btnGraficas_Click.UseVisualStyleBackColor = true;
            this.btnGraficas_Click.Click += new System.EventHandler(this.btnGraficas_Click_Click);
            // 
            // ProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnGraficas_Click);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picSueloF);
            this.Controls.Add(this.picObstaculoF);
            this.Controls.Add(this.picObjetivoF);
            this.Controls.Add(this.picTejoF);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProcessForm";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.ProcessForm_Load);
            this.Move += new System.EventHandler(this.ProcessForm_Move);
            ((System.ComponentModel.ISupportInitialize)(this.picSueloF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObstaculoF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObjetivoF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTejoF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSueloF;
        private System.Windows.Forms.PictureBox picObstaculoF;
        private System.Windows.Forms.PictureBox picObjetivoF;
        private System.Windows.Forms.PictureBox picTejoF;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGraficas_Click;
    }
}