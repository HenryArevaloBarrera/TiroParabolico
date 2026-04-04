namespace TiroParabolico
{
    partial class GraficasForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartTrayectoria = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTiempo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartVelocidad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listRebotes = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartTrayectoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVelocidad)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTrayectoria
            // 
            chartArea4.Name = "ChartArea1";
            this.chartTrayectoria.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartTrayectoria.Legends.Add(legend4);
            this.chartTrayectoria.Location = new System.Drawing.Point(95, 24);
            this.chartTrayectoria.Name = "chartTrayectoria";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartTrayectoria.Series.Add(series4);
            this.chartTrayectoria.Size = new System.Drawing.Size(366, 225);
            this.chartTrayectoria.TabIndex = 0;
            this.chartTrayectoria.Text = "chart1";
            // 
            // chartTiempo
            // 
            chartArea5.Name = "ChartArea1";
            this.chartTiempo.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartTiempo.Legends.Add(legend5);
            this.chartTiempo.Location = new System.Drawing.Point(640, 24);
            this.chartTiempo.Name = "chartTiempo";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartTiempo.Series.Add(series5);
            this.chartTiempo.Size = new System.Drawing.Size(366, 225);
            this.chartTiempo.TabIndex = 1;
            this.chartTiempo.Text = "chart2";
            // 
            // chartVelocidad
            // 
            chartArea6.Name = "ChartArea1";
            this.chartVelocidad.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartVelocidad.Legends.Add(legend6);
            this.chartVelocidad.Location = new System.Drawing.Point(95, 294);
            this.chartVelocidad.Name = "chartVelocidad";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartVelocidad.Series.Add(series6);
            this.chartVelocidad.Size = new System.Drawing.Size(366, 225);
            this.chartVelocidad.TabIndex = 2;
            this.chartVelocidad.Text = "chart3";
            // 
            // listRebotes
            // 
            this.listRebotes.FormattingEnabled = true;
            this.listRebotes.ItemHeight = 16;
            this.listRebotes.Location = new System.Drawing.Point(640, 294);
            this.listRebotes.Name = "listRebotes";
            this.listRebotes.Size = new System.Drawing.Size(363, 228);
            this.listRebotes.TabIndex = 3;
            // 
            // GraficasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 578);
            this.Controls.Add(this.listRebotes);
            this.Controls.Add(this.chartVelocidad);
            this.Controls.Add(this.chartTiempo);
            this.Controls.Add(this.chartTrayectoria);
            this.Name = "GraficasForm";
            this.Text = "GraficasForm";
            this.Load += new System.EventHandler(this.GraficasForm_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GraficasForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.chartTrayectoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVelocidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTrayectoria;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTiempo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVelocidad;
        private System.Windows.Forms.ListBox listRebotes;
    }
}