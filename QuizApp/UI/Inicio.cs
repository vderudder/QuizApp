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
            new UI.MenuQuiz().Show();
        }
    }
}