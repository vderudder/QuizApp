using QuizApp.Storage;

namespace QuizApp.UI
{
    public partial class PuntajeQuiz : Form
    {
        private SesionDTO iSesion;
        public PuntajeQuiz(SesionDTO sesionActual)
        {
            InitializeComponent();

            iSesion = sesionActual;

            puntajeLabel.Text = "Score: " + iSesion.iPuntaje.ToString("0.##") + " points";
            tiempoLabel.Text = "Time used: " + iSesion.iTiempo.ToString("0.##") + " seconds";
            fechaLabel.Text = "Date: " + iSesion.iFecha.ToString("d");
        }

        private void volverMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
