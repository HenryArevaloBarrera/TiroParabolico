using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiroParabolico
{
    public partial class ProcessForm : Form
    {

        BackForm backForm;

        int startMouseX, startMouseY;
        int deltaX, deltaY;
        int initialTejoX, initialTejoY;
        double x0, y0;
        double v0x, v0y;

        double gravity = 9.8;
        double t = 0;

        // Variables para rebotes
        int rebotesRealizados = 0;
        int maxRebotes = 2;
        bool haColisionadoConObjetivo = false;
        Random random = new Random();

        // Variables para el área de la pantalla
        int limiteSuperiorY = 50;
        int limiteInferiorY;

        // Guardar la posición X original del objetivo
        int objetivoOriginalX;

        private void picTejoF_Clic(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startMouseX = e.X;
                startMouseY = e.Y;
            }
        }

        private void picTejoF_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int newY = picTejoF.Location.Y + e.Y - startMouseY;
                int newX = picTejoF.Location.X + e.X - startMouseX;

                picTejoF.Location = new Point(newX, newY);

                deltaX = initialTejoX - picTejoF.Location.X;
                deltaY = picTejoF.Location.Y - initialTejoY;
            }
        }

        private void picTejoF_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Reiniciar variables para nuevo lanzamiento
                t = 0;
                rebotesRealizados = 0;
                haColisionadoConObjetivo = false;

                x0 = deltaX * -1;
                y0 = deltaY * -1;
                v0x = deltaX;
                v0y = deltaY;
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double xt = v0x * t + x0;
            double yt = -0.5 * gravity * Math.Pow(t, 2) + v0y * t + y0;

            // Actualizar la posición del Tejo
            picTejoF.Location = new Point(
                initialTejoX + (int)xt,
                initialTejoY - (int)yt
            );

            // Verificar colisiones en orden de prioridad
            bool colisionDetectada = false;

            // 1. Colisión con el objetivo
            if (!haColisionadoConObjetivo && picTejoF.Bounds.IntersectsWith(picObjetivoF.Bounds))
            {
                colisionDetectada = true;
                haColisionadoConObjetivo = true;

                // Registrar datos del rebote en objetivo
                RegistrarDatosRebote("OBJETIVO", xt, yt);

                // Aplicar rebote: reducir velocidad en 40% y cambiar dirección vertical
                v0x = v0x * 0.6;
                v0y = -v0y * 0.6;

                // Cambiar posición del objetivo (solo en Y, dentro de la pantalla)
                CambiarPosicionObjetivo();

                // Reiniciar tiempo y posición para el rebote
                t = 0;
                x0 = xt;
                y0 = yt;

                rebotesRealizados++;
            }
            // 2. Colisión con el suelo
            else if (picTejoF.Bounds.IntersectsWith(picSueloF.Bounds))
            {
                if (rebotesRealizados < maxRebotes)
                {
                    colisionDetectada = true;

                    // Registrar datos del rebote en suelo
                    RegistrarDatosRebote("SUELO", xt, 0);

                    // Rebote con pérdida del 40% (solo vertical, manteniendo dirección horizontal)
                    v0y = Math.Abs(v0y) * 0.6;
                    v0x = v0x * 0.6;

                    // Reiniciar tiempo y posición para el rebote
                    t = 0;
                    x0 = xt;
                    y0 = 0;

                    rebotesRealizados++;
                }
                else
                {
                    // No más rebotes permitidos, detener simulación
                    timer1.Enabled = false;
                    MostrarMensajeFinSimulacion();
                    return;
                }
            }
            // 3. Colisión con el obstáculo
            else if (picTejoF.Bounds.IntersectsWith(picObstaculoF.Bounds))
            {
                if (rebotesRealizados < maxRebotes)
                {
                    colisionDetectada = true;

                    // Registrar datos del rebote en obstáculo
                    RegistrarDatosRebote("OBSTÁCULO", xt, yt);

                    // Rebote con pérdida del 40%
                    v0x = v0x * 0.6;
                    v0y = -v0y * 0.6;

                    // Reiniciar tiempo y posición para el rebote
                    t = 0;
                    x0 = xt;
                    y0 = yt;

                    rebotesRealizados++;
                }
                else
                {
                    timer1.Enabled = false;
                    MostrarMensajeFinSimulacion();
                    return;
                }
            }

            // Si se detectó colisión, reiniciamos el timer para continuar con el rebote
            if (colisionDetectada)
            {
                // Pequeña pausa visual (opcional)
                return;
            }

            // Verificar si el tejo salió de la pantalla (muy abajo o muy a la derecha)
            if (picTejoF.Location.Y > this.ClientSize.Height + 100 ||
                picTejoF.Location.X > this.ClientSize.Width + 100)
            {
                timer1.Enabled = false;
                MostrarMensajeFinSimulacion();
                return;
            }

            // Avanzar tiempo
            t += 0.05; // Reducido para mejor precisión
        }

        private void RegistrarDatosRebote(string tipo, double x, double y)
        {
            // Mostrar en consola o en un label si lo tienes
            Console.WriteLine($"=== REBOTE EN {tipo} #{rebotesRealizados + 1} ===");
            Console.WriteLine($"Tiempo: {t:F2} s");
            Console.WriteLine($"Posición: ({x:F2}, {y:F2}) m");
            Console.WriteLine($"Velocidad: ({v0x:F2}, {v0y:F2}) m/s");
            Console.WriteLine($"Magnitud: {Math.Sqrt(v0x * v0x + v0y * v0y):F2} m/s");
            Console.WriteLine($"Ángulo: {Math.Atan2(v0y, v0x) * 180 / Math.PI:F2}°");
            Console.WriteLine("");
        }

        private void CambiarPosicionObjetivo()
        {
            // Calcular límite inferior (evitar que se salga del suelo)
            limiteInferiorY = picSueloF.Location.Y - picObjetivoF.Height - 10;

            // Asegurar que el límite superior no sea mayor que el inferior
            int minY = Math.Max(limiteSuperiorY, 50);
            int maxY = Math.Min(limiteInferiorY, picSueloF.Location.Y - picObjetivoF.Height - 10);

            if (maxY <= minY)
            {
                maxY = minY + 100;
            }

            // Generar nueva posición Y aleatoria dentro de los límites
            int nuevaY = random.Next(minY, maxY);

            // Mantener la posición X original del objetivo
            int nuevaX = objetivoOriginalX;

            // Actualizar posición del objetivo
            picObjetivoF.Location = new Point(nuevaX, nuevaY);

            // Cambiar color para indicar que fue golpeado

            // Restaurar color después de un tiempo
            System.Windows.Forms.Timer timerColor = new System.Windows.Forms.Timer();
            timerColor.Interval = 500;
            timerColor.Tick += (s, ev) =>
            {
               
                timerColor.Stop();
                timerColor.Dispose();
            };
            timerColor.Start();

            Console.WriteLine($"Objetivo movido a nueva posición: X={nuevaX}, Y={nuevaY}");
        }

        private void InicializarPosicionObjetivo()
        {
            // Calcular límite inferior (evitar que se salga del suelo)
            limiteInferiorY = picSueloF.Location.Y - picObjetivoF.Height - 10;

            // Asegurar que el límite superior no sea mayor que el inferior
            int minY = Math.Max(limiteSuperiorY, 50);
            int maxY = Math.Min(limiteInferiorY, picSueloF.Location.Y - picObjetivoF.Height - 10);

            if (maxY <= minY)
            {
                maxY = minY + 100;
            }

            // Generar posición Y aleatoria inicial
            int posicionYInicial = random.Next(minY, maxY);

            // Mantener la posición X original del objetivo
            int posicionXInicial = objetivoOriginalX;

            // Establecer la posición inicial del objetivo
            picObjetivoF.Location = new Point(posicionXInicial, posicionYInicial);

            Console.WriteLine($"Objetivo inicializado en: X={posicionXInicial}, Y={posicionYInicial}");
        }

        private void MostrarMensajeFinSimulacion()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("=== SIMULACIÓN FINALIZADA ===");
            Console.WriteLine($"Rebotes realizados: {rebotesRealizados}");
            if (haColisionadoConObjetivo)
            {
                Console.WriteLine("¡OBJETIVO GOLPEADO CON ÉXITO! 🎯");
            }
            else
            {
                Console.WriteLine("No se logró golpear el objetivo. 💔");
            }
            Console.WriteLine("========================================");
        }

        private void ProcessForm_Move(object sender, EventArgs e)
        {
            if (backForm != null)
            {
                backForm.Location = this.Location;
            }
        }

        private void picTejoF_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startMouseX = e.X;
                startMouseY = e.Y;
            }
        }

        private void picTejoF_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int newY = picTejoF.Location.Y + e.Y - startMouseY;
                int newX = picTejoF.Location.X + e.X - startMouseX;

                picTejoF.Location = new Point(newX, newY);

                deltaX = initialTejoX - picTejoF.Location.X;
                deltaY = picTejoF.Location.Y - initialTejoY;
            }
        }

        private void picObjetivoF_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        public ProcessForm()
        {
            InitializeComponent();
        }

        private void ProcessForm_Load(object sender, EventArgs e)
        {
            backForm = new BackForm()
            {
                StartPosition = FormStartPosition.Manual,
                Size = this.Size,
                Location = this.Location,
                ShowInTaskbar = false
            };
            backForm.Show();
            this.BringToFront();

            // Ubicar PictureBox
            picTejoF.Location = backForm.TejoLocation;
            picTejoF.Size = backForm.TejoSize;
            picSueloF.Location = backForm.SueloLocation;
            picSueloF.Size = backForm.SueloSize;

            // Guardar la posición X original del objetivo
            objetivoOriginalX = backForm.ObjetivoLocation.X;

            // Establecer el tamaño del objetivo
            picObjetivoF.Size = backForm.ObjetivoSize;

            // Establecer posición del obstáculo
            picObstaculoF.Location = backForm.ObstaculoLocation;
            picObstaculoF.Size = backForm.ObstaculoSize;

            initialTejoX = picTejoF.Location.X;
            initialTejoY = picTejoF.Location.Y;

            // Calcular límite inferior para el objetivo (justo encima del suelo)
            limiteInferiorY = picSueloF.Location.Y - picObjetivoF.Height - 10;

            // Inicializar el objetivo con posición Y aleatoria (X fija)
            InicializarPosicionObjetivo();

            // Configurar color del objetivo

            Console.WriteLine($"Límites configurados:");
            Console.WriteLine($"  Y mínimo: {limiteSuperiorY}");
            Console.WriteLine($"  Y máximo: {limiteInferiorY}");
            Console.WriteLine($"  X fijo del objetivo: {objetivoOriginalX}");
        }

        private void picSueloF_Click(object sender, EventArgs e)
        {

        }
    }
}