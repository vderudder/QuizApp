using QuizApp.UI;
using System.Diagnostics;

namespace QuizApp
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();

            var listaPreguntas = Contexto.iServicioBD.Pruebas.Select(p => p.Pregunta).ToList();

            foreach ( var p in listaPreguntas )
            {
                Debug.WriteLine(p);

            }
        }

        private void botonJugar_Click(object sender, EventArgs e)
        {
            new UI.MenuQuiz().Show();
        }

        private void botonAdministrar_Click(object sender, EventArgs e)
        {
            new UI.AdministrarQuiz().Show();
        }

        private void botonRanking_Click(object sender, EventArgs e)
        {
            new UI.RankingQuiz().Show();
        }
    }
}