using Quizzify.Excepcion;

namespace QuizApp.UI
{
    public partial class AdministrarQuiz : Form
    {
        public AdministrarQuiz()
        {
            InitializeComponent();

            // Centrar titulos
            tituloLabel.Location = new Point(this.Location.X + this.Width / 2 - tituloLabel.Width / 2, 40);

        }

        private async void BotonGuardar_Click(object sender, EventArgs e)
        {
            // Cambia el cursor mientras espera
            Cursor.Current = Cursors.WaitCursor;

            // Chequea que haya texto en el input
            if (urlInput.Text.Length > 0)
            {
                // Chequea que la url sea valida
                if (Uri.IsWellFormedUriString(urlInput.Text, UriKind.Absolute))
                {
                    try
                    {

                        await Contexto.Instancia.AdminFacade.GuardarPreguntas(urlInput.Text);
                        Cursor.Current = Cursors.WaitCursor;


                        MessageBox.Show("The questions were saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        // La query tiene un parametro invalido
                        if (ex is InvalidParameterException)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        // La query no arroja resultados
                        else if (ex is NoResultException)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        // Otro tipo de error, ej: no conexion con BD
                        else
                        {
                            MessageBox.Show("Something went wrong. Try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                        urlInput.Text = "";
                    }

                }
                else
                {
                    // El link no tiene formato de url
                    MessageBox.Show("The URL address is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    urlInput.Text = "";

                }

            }
            else
            {
                // No se ha ingresado una url
                MessageBox.Show("You need to enter an URL address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void AdministrarQuiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Inicio().Show();
        }
    }
}
