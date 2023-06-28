using Quizzify.Facade;
using Quizzify.IO;

namespace QuizApp.UI
{
    public partial class RankingQuiz : Form
    {
        private SesionFacade iSesionFacade = Contexto.Instancia.SesionFacade;
        private List<SesionDTO> iRanking = new List<SesionDTO>();

        public RankingQuiz()
        {
            InitializeComponent();

            try
            {
                // Cambia el cursor mientras espera
                Cursor.Current = Cursors.WaitCursor;
                // Obtiene el ranking
                iRanking = iSesionFacade.GetRanking();

            }
            catch (Exception)
            {
                // Si sale mal, cierra la ventana
                MessageBox.Show("Something went wrong. Try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }


            // Si no hay sesiones
            if (iRanking.Count == 0)
            {
                rankingTable.Hide();

                this.Size = new Size(500, 300);

                tituloLabel.Location = new Point(this.Location.X + this.Width / 2 - tituloLabel.Width / 2, 90);

                noResultadoLabel.Location = new Point(this.Location.X + this.Width / 2 - noResultadoLabel.Width / 2, 130);
            }

            // Si hay sesiones
            else
            {
                noResultadoLabel.Hide();

                tituloLabel.Location = new Point(this.Location.X + this.Width / 2 - tituloLabel.Width / 2, 40);

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
                    if (row > iRanking.Count)
                    {
                        puestoLabel.Text = row.ToString();
                        // Propiedades para centrar el texto
                        puestoLabel.Anchor = AnchorStyles.None;
                        puestoLabel.AutoSize = false;
                        puestoLabel.TextAlign = ContentAlignment.MiddleCenter;

                        puestoLabel.ForeColor = Color.FromArgb(38, 70, 83);

                        rankingTable.Controls.Add(puestoLabel, 0, row);


                    }
                    else
                    {
                        puestoLabel.Text = row.ToString();
                        usuarioLabel.Text = iRanking[row - 1].Usuario.Nombre;
                        puntajeLabel.Text = iRanking[row - 1].Puntaje.ToString("0.##");
                        tiempoLabel.Text = iRanking[row - 1].Tiempo.ToString("0.##"); ;
                        fechaLabel.Text = iRanking[row - 1].Fecha.ToString("d");

                        puestoLabel.ForeColor = Color.FromArgb(38, 70, 83);
                        usuarioLabel.ForeColor = Color.FromArgb(38, 70, 83);
                        puntajeLabel.ForeColor = Color.FromArgb(38, 70, 83);
                        tiempoLabel.ForeColor = Color.FromArgb(38, 70, 83);
                        fechaLabel.ForeColor = Color.FromArgb(38, 70, 83);

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

        private void RankingQuiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Inicio().Show();
        }
    }
}
