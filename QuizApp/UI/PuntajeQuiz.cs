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

            puntajeLabel.Text = "Puntaje: " + iSesion.iPuntaje.ToString("0.##") + " puntos";
            tiempoLabel.Text = "Tiempo: " + iSesion.iTiempo.ToString("0.##") + " segundos";
            fechaLabel.Text = "Fecha: " + iSesion.iFecha.ToString("d");
        }

        private void volverMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
