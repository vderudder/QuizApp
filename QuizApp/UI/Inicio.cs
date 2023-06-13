using QuizApp.UI;
using Quizzify.Facade;
using Quizzify.UI;
using System.Diagnostics;

namespace QuizApp
{
    public partial class Inicio : Form
    {
        private PreguntaFacade iPreguntaFacade = Contexto.Instancia.PreguntaFacade;

        public Inicio()
        {
            InitializeComponent();
        }

        private void botonJugar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se fija la cantidad de fuentes de datos, y salta ventana para elegir
                if(iPreguntaFacade.GetOrigenes().Count > 1)
                {
                    new ElegirOrigenDatos(false).Show();
                    this.Hide();
                }
                // Como solo se tiene de origen a OTDB va a abrir directamente el menu de juego
                else
                {
                    new UI.MenuQuiz("otdb").Show();
                    this.Hide();
                }
                               

            }
            catch (Exception)
            {
                // Si sale mal vuelve al menu inicio
                this.Show();
            }
        }

        private void botonAdministrar_Click(object sender, EventArgs e)
        {

            try
            {
                new ElegirOrigenDatos(true).Show();
                this.Hide();
            }
            catch (Exception)
            {
                // Si sale mal vuelve al menu inicio
                this.Show();
            }

        }

        private void botonRanking_Click(object sender, EventArgs e)
        {
            try
            {
                new UI.RankingQuiz().Show();
                this.Hide();
            }
            catch (Exception)
            {
                // Si sale mal vuelve al menu inicio
                this.Show();
            }
        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}