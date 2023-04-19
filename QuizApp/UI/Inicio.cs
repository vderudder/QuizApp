using QuizApp.UI;
using System.Diagnostics;

namespace QuizApp
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void botonJugar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UI.MenuQuiz().Show();
        }

        private void botonAdministrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UI.AdministrarQuiz().Show();
        }

        private void botonRanking_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UI.RankingQuiz().Show();
        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}