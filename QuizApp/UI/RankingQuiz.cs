using QuizApp.Facade;

namespace QuizApp.UI
{
    public partial class RankingQuiz : Form
    {
        public RankingQuiz()
        {
            InitializeComponent();

            var sesionFacade = new SesionFacade();
            var ranking = sesionFacade.getRanking();

            for (int row = 1; row < rankingTable.RowCount; row++)
            {
                Label puestoLabel = new Label();
                Label usuarioLabel = new Label();
                Label puntajeLabel = new Label();
                Label tiempoLabel = new Label();
                Label fechaLabel = new Label();

                if (row > ranking.Count)
                {
                    puestoLabel.Text = row.ToString();
                    puestoLabel.Anchor = AnchorStyles.None;
                    puestoLabel.AutoSize = false;
                    puestoLabel.TextAlign = ContentAlignment.MiddleCenter;

                    rankingTable.Controls.Add(puestoLabel, 0, row);


                }
                else
                {
                    puestoLabel.Text = row.ToString();
                    usuarioLabel.Text = ranking[row - 1].iUsuarioId;
                    puntajeLabel.Text = ranking[row - 1].iPuntaje.ToString("0.##");
                    tiempoLabel.Text = ranking[row - 1].iTiempo.ToString("0.##"); ;
                    fechaLabel.Text = ranking[row - 1].iFecha.ToString("d");

                    puestoLabel.Anchor = AnchorStyles.None;
                    puestoLabel.AutoSize = false;
                    puestoLabel.TextAlign = ContentAlignment.MiddleCenter;
                    usuarioLabel.Anchor = AnchorStyles.None;
                    usuarioLabel.AutoSize = false;
                    usuarioLabel.TextAlign = ContentAlignment.MiddleCenter;
                    puntajeLabel.Anchor = AnchorStyles.None;
                    puntajeLabel.AutoSize = false;
                    puntajeLabel.TextAlign = ContentAlignment.MiddleCenter;
                    tiempoLabel.Anchor = AnchorStyles.None;
                    tiempoLabel.AutoSize = false;
                    tiempoLabel.TextAlign = ContentAlignment.MiddleCenter;
                    fechaLabel.Anchor = AnchorStyles.None;
                    fechaLabel.AutoSize = false;
                    fechaLabel.TextAlign = ContentAlignment.MiddleCenter;

                    rankingTable.Controls.Add(puestoLabel, 0, row);
                    rankingTable.Controls.Add(usuarioLabel, 1, row);
                    rankingTable.Controls.Add(puntajeLabel, 2, row);
                    rankingTable.Controls.Add(tiempoLabel, 3, row);
                    rankingTable.Controls.Add(fechaLabel, 4, row);



                }

            }
        }
    }
}
