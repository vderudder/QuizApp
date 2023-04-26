using QuizApp.Storage.DBStorage;

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

        private void VolverMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new Inicio().Show();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
