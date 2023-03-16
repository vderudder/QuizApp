using QuizApp.Facade;

namespace QuizApp.UI
{
    public partial class RankingQuiz : Form
    {
        private SesionFacade iSesionFacade = Contexto.iInstancia.iSesionFacade;

        public RankingQuiz()
        {
            InitializeComponent();

            // Obtiene la lista de ranking
            var ranking = iSesionFacade.getRanking();

            // Recorrer la tabla, empezando por la fila 1 (porque la fila 0 es el header)
            for (int row = 1; row < rankingTable.RowCount; row++)
            {
                // Se crean los elementos UI
                Label puestoLabel = new Label();
                Label usuarioLabel = new Label();
                Label puntajeLabel = new Label();
                Label tiempoLabel = new Label();
                Label fechaLabel = new Label();

                // Hay menos de 20 sesiones en la lista de ranking, solo rellenar el texto del puesto para el resto
                if (row > ranking.Count)
                {
                    puestoLabel.Text = row.ToString();
                    // Propiedades para centrar el texto
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

                    // Propiedades para centrar el texto
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
