using Quizzify.IO;

namespace QuizApp.UI
{
    public partial class PuntajeQuiz : Form
    {
        private SesionDTO iSesion;
        public PuntajeQuiz(SesionDTO sesionActual)
        {
            InitializeComponent();

            // Cambia el cursor mientras espera
            Cursor.Current = Cursors.WaitCursor;

            iSesion = sesionActual;

            puntajeLabel.Text = "Score: " + iSesion.Puntaje.ToString("0.##") + " points";
            tiempoLabel.Text = "Time used: " + iSesion.Tiempo.ToString("0.##") + " seconds";
            fechaLabel.Text = "Date: " + iSesion.Fecha.ToString("d");
        }

        private void VolverMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Inicio().Show();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void PuntajeQuiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);

        }
    }
}
