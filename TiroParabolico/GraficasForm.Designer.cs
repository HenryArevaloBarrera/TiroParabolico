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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            chartArea1.Name = "ChartArea1";
            this.chartTrayectoria.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTrayectoria.Legends.Add(legend1);
            this.chartTrayectoria.Location = new System.Drawing.Point(95, 24);
            this.chartTrayectoria.Name = "chartTrayectoria";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTrayectoria.Series.Add(series1);
            this.chartTrayectoria.Size = new System.Drawing.Size(366, 225);
            this.chartTrayectoria.TabIndex = 0;
            this.chartTrayectoria.Text = "chart1";
            this.chartTrayectoria.Click += new System.EventHandler(this.chartTrayectoria_Click);
            // 
            // chartTiempo
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTiempo.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTiempo.Legends.Add(legend2);
            this.chartTiempo.Location = new System.Drawing.Point(640, 24);
            this.chartTiempo.Name = "chartTiempo";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTiempo.Series.Add(series2);
            this.chartTiempo.Size = new System.Drawing.Size(366, 225);
            this.chartTiempo.TabIndex = 1;
            this.chartTiempo.Text = "chart2";
            // 
            // chartVelocidad
            // 
            chartArea3.Name = "ChartArea1";
            this.chartVelocidad.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartVelocidad.Legends.Add(legend3);
            this.chartVelocidad.Location = new System.Drawing.Point(95, 294);
            this.chartVelocidad.Name = "chartVelocidad";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartVelocidad.Series.Add(series3);
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