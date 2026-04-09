using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TiroParabolico
{
    public partial class GraficasForm : Form
    {
        public GraficasForm()
        {
            InitializeComponent();
        }

        public void CargarDatos(
        List<double> t,
        List<double> x,
        List<double> y,
        List<double> vx,
        List<double> vy,
        List<double> v,
        List<double> ang,
        List<string> tipoRebote,
        List<double> rebX,
        List<double> rebY)
        {
            GraficarTrayectoria(x, y, rebX, rebY);
            GraficarTiempo(t, x, y);
            GraficarVelocidad(t, vx, vy, v);
            MostrarRebotes(tipoRebote, rebX, rebY);
        }

        public void ActualizarDatos(
        double t,
        double x,
        double y,
        double vx,
        double vy,
        double v)
        {
            // Trayectoria
            chartTrayectoria.Series[0].Points.AddXY(x, y);

            // y vs t
            chartTiempo.Series["y(t)"].Points.AddXY(t, y);
            chartTiempo.Series["x(t)"].Points.AddXY(t, x);

            // velocidades
            chartVelocidad.Series["vx"].Points.AddXY(t, vx);
            chartVelocidad.Series["vy"].Points.AddXY(t, vy);
            chartVelocidad.Series["|v|"].Points.AddXY(t, v);
        }

        private void GraficarTrayectoria(List<double> x, List<double> y, List<double> rebX, List<double> rebY)
        {
            chartTrayectoria.Series.Clear();

            var serie = chartTrayectoria.Series.Add("Trayectoria");
            serie.ChartType = SeriesChartType.Line;

            for (int i = 0; i < x.Count; i++)
                serie.Points.AddXY(x[i], y[i]);

            var rebotes = chartTrayectoria.Series.Add("Rebotes");
            rebotes.ChartType = SeriesChartType.Point;
            rebotes.MarkerSize = 10;

            for (int i = 0; i < rebX.Count; i++)
                rebotes.Points.AddXY(rebX[i], rebY[i]);
        }


        private void GraficarTiempo(List<double> t, List<double> x, List<double> y)
        {
            chartTiempo.Series.Clear();

            var xt = chartTiempo.Series.Add("x(t)");
            xt.ChartType = SeriesChartType.Line;

            var yt = chartTiempo.Series.Add("y(t)");
            yt.ChartType = SeriesChartType.Line;

            for (int i = 0; i < t.Count; i++)
            {
                xt.Points.AddXY(t[i], x[i]);
                yt.Points.AddXY(t[i], y[i]);
            }
        }


        private void GraficarVelocidad(List<double> t, List<double> vx, List<double> vy, List<double> v)
        {
            chartVelocidad.Series.Clear();

            var sx = chartVelocidad.Series.Add("vx");
            var sy = chartVelocidad.Series.Add("vy");
            var sm = chartVelocidad.Series.Add("|v|");

            sx.ChartType = SeriesChartType.Line;
            sy.ChartType = SeriesChartType.Line;
            sm.ChartType = SeriesChartType.Line;

            for (int i = 0; i < t.Count; i++)
            {
                sx.Points.AddXY(t[i], vx[i]);
                sy.Points.AddXY(t[i], vy[i]);
                sm.Points.AddXY(t[i], v[i]);
            }
        }

        private void MostrarRebotes(List<string> tipo, List<double> x, List<double> y)
        {
            listRebotes.Items.Clear();

            for (int i = 0; i < tipo.Count; i++)
            {
                listRebotes.Items.Add(
                    $"Rebote {i + 1} ({tipo[i]}) → X:{x[i]:F2} Y:{y[i]:F2}"
                );
            }
        }

        private void GraficasForm_Load(object sender, EventArgs e)
        {
            // Trayectoria
            chartTrayectoria.Series.Clear();
            chartTrayectoria.Series.Add("Trayectoria");
            chartTrayectoria.Series[0].ChartType = SeriesChartType.Line;

            // Tiempo
            chartTiempo.Series.Clear();
            chartTiempo.Series.Add("x(t)");
            chartTiempo.Series.Add("y(t)");

            chartTiempo.Series["x(t)"].ChartType = SeriesChartType.Line;
            chartTiempo.Series["y(t)"].ChartType = SeriesChartType.Line;

            // Velocidad
            chartVelocidad.Series.Clear();
            chartVelocidad.Series.Add("vx");
            chartVelocidad.Series.Add("vy");
            chartVelocidad.Series.Add("|v|");

            chartVelocidad.Series["vx"].ChartType = SeriesChartType.Line;
            chartVelocidad.Series["vy"].ChartType = SeriesChartType.Line;
            chartVelocidad.Series["|v|"].ChartType = SeriesChartType.Line;
        }

        public void Limpiar()
        {
            foreach (var chart in new[] { chartTrayectoria, chartTiempo, chartVelocidad })
            {
                foreach (var s in chart.Series)
                    s.Points.Clear();
            }

            if (listRebotes != null)
            {
                listRebotes.Items.Clear();
            }
        }

        private void GraficasForm_MouseUp(object sender, MouseEventArgs e)
        {
       
        }

        private void chartTrayectoria_Click(object sender, EventArgs e)
        {

        }

        public void AgregarRebote(string tipo, double x, double y)
        {
            // 1. Añadir el registro a la lista (el recuadro blanco)
            int numRebote = listRebotes.Items.Count + 1;
            listRebotes.Items.Add($"Rebote {numRebote} ({tipo}) → X:{x:F2} Y:{y:F2}");

            // 2. Añadir el punto al gráfico de trayectoria
            // Si la serie de "Rebotes" no existe, la creamos en tiempo real
            if (chartTrayectoria.Series.IndexOf("Rebotes") == -1)
            {
                var rebotes = chartTrayectoria.Series.Add("Rebotes");
                rebotes.ChartType = SeriesChartType.Point;
                rebotes.MarkerSize = 10;
                rebotes.MarkerStyle = MarkerStyle.Circle;
                rebotes.Color = Color.Red; // Puedes cambiar el color si prefieres
            }

            // Dibujamos la coordenada del salto
            chartTrayectoria.Series["Rebotes"].Points.AddXY(x, y);
        }
    }



}
