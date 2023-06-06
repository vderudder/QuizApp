using Quizzify.Facade;
using Quizzify.IO;

namespace QuizApp.UI
{
    public partial class MenuQuiz : Form
    {

        private PreguntaFacade iPreguntaFacade = Contexto.iInstancia.iPreguntaFacade;
        private UsuarioFacade iUsuarioFacade = Contexto.iInstancia.iUsuarioFacade;

        private string iNombreUsuario;

        private List<PreguntaDTO> iPreguntas;
        private List<CategoriaDTO> iCategorias;
        private List<DificultadDTO> iDificultades;
        private List<UsuarioDTO> iUsuarios;

        public MenuQuiz()
        {
            InitializeComponent();

            try
            {
                // Cambia el cursor mientras espera
                Cursor.Current = Cursors.WaitCursor;
                // Obtiene las categorias y dificultades
                iCategorias = iPreguntaFacade.GetCategorias();
                iDificultades = iPreguntaFacade.GetDificultades();
                // Obtiene los usuarios
                iUsuarios = iUsuarioFacade.GetUsuarios();

                if (iCategorias.Count == 0 || iDificultades.Count == 0)
                {
                    // Si no hay categorias o dificultades cargadas
                    MessageBox.Show("There are no categories and/or difficulties loaded", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    // Agrega a la lista del comboBox los elementos de la lista de categorias
                    for (int i = 0; i < iCategorias.Count; i++)
                    {
                        categoriaList.Items.Add(iCategorias[i].iCategoria);
                    }

                    // Agrega a la lista del comboBox los elementos de la lista de dificultades
                    for (int i = 0; i < iDificultades.Count; i++)
                    {
                        // Mostrar la dificultad de una mejor manera (con la primera letra en mayuscula)
                        dificultadList.Items.Add(iDificultades[i].iDificultad[0].ToString().ToUpper() + iDificultades[i].iDificultad.Substring(1));
                    }

                    // Agrega a la lista del comboBox los elementos de la lista de usuarios
                    for (int i = 0; i < iUsuarios.Count; i++)
                    {
                        usuarioList.Items.Add(iUsuarios[i].iNombre);
                    }
                }

            }
            catch (Exception)
            {
                // Si sale mal, cierra la ventana
                MessageBox.Show("Something went wrong. Try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }           

        }

        private void botonIniciarQuiz_Click(object sender, EventArgs e)
        {
            // Cambia el cursor mientras espera
            Cursor.Current = Cursors.WaitCursor;

            // Fija si se seleccionaron todas las opciones
            if (dificultadList.SelectedIndex >= 0 && categoriaList.SelectedIndex >= 0 && usuarioList.SelectedIndex > 0 && cantidadPreguntas.Value > 0)
            {
                // Tomar los datos de los inputs
                iNombreUsuario = usuarioList.Text;

                // Volver al original
                string dificultad = dificultadList.Text.ToLower();

                string categoria = categoriaList.Text;

                int cantidadPreg = (int)cantidadPreguntas.Value;

                try
                {
                    // Obtiene las preguntas filtradas
                    iPreguntas = iPreguntaFacade.GetPreguntas(dificultad, categoria, cantidadPreg);

                    // Si hay preguntas, pasa a la siguiente ventana pasandole los datos de usuario y las preguntas
                    if (iPreguntas.Count >= 10)
                    {
                        new SesionQuiz(iNombreUsuario, iPreguntas).Show();

                        // Resetar los inputs
                        usuarioList.SelectedIndex = 0;
                        dificultadList.SelectedIndex = 0;
                        categoriaList.SelectedIndex = 0;
                        cantidadPreguntas.ResetText();

                        // Cerrar la ventana
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("There aren't enough questions for your selected options. Please, choose other options", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
                catch (Exception)
                {
                    // Si sale mal, cierra la ventana
                    MessageBox.Show("Something went wrong. Try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                


            }
            // Faltan campos por seleccionar
            else
            {
                MessageBox.Show("Please, select all the options", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void usuarioList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;

            // Tomar la primera opcion: la de crear usuario
            if (senderComboBox.SelectedIndex == 0)
            {
                string value = "";
                if (ventanaNuevoUsuario(ref value) == DialogResult.OK)
                {
                    // Guardo el valor para pasarlo
                    iNombreUsuario = value;
                    // Temporalmente se agrega a la lista del combobox
                    usuarioList.Items.Add(value);
                    usuarioList.Text = value;
                }
            }

        }

        /// <summary>
        /// Desplega ventana para ingresar nuevo usuario
        /// </summary>
        /// <param name="value">Valor del input de la ventana</param>
        /// <returns>Valor de lo ingresado en el input</returns>
        public static DialogResult ventanaNuevoUsuario(ref string value)
        {
            Form ventana = new Form();
            Label tituloLabel = new Label();
            TextBox usuarioInput = new TextBox();
            Button botonOk = new Button();
            Button botonCancelar = new Button();

            ventana.Text = "New user";
            ventana.Icon = Quizzify.Properties.Resources.favicon;
            tituloLabel.Text = "Insert your user name";
            tituloLabel.Font = new Font("Segoe UI", 10.0f);


            botonOk.Text = "OK";
            botonOk.Font = new Font("Segoe UI", 12.0f, FontStyle.Bold);
            botonCancelar.Text = "Cancel";
            botonCancelar.Font = new Font("Segoe UI", 12.0f, FontStyle.Bold);
            botonOk.DialogResult = DialogResult.OK;
            botonCancelar.DialogResult = DialogResult.Cancel;

            tituloLabel.SetBounds(36, 36, 372, 13);
            usuarioInput.SetBounds(36, 86, 420, 20);
            botonOk.SetBounds(36, 160, 160, 60);
            botonCancelar.SetBounds(220, 160, 160, 60);

            tituloLabel.AutoSize = true;
            ventana.ClientSize = new Size(500, 256);
            ventana.FormBorderStyle = FormBorderStyle.FixedDialog;
            ventana.StartPosition = FormStartPosition.CenterScreen;
            ventana.MinimizeBox = false;
            ventana.MaximizeBox = false;

            ventana.Controls.AddRange(new Control[] { tituloLabel, usuarioInput, botonOk, botonCancelar });
            ventana.AcceptButton = botonOk;
            ventana.CancelButton = botonCancelar;

            DialogResult dialogResult = ventana.ShowDialog();

            value = usuarioInput.Text;
            return dialogResult;
        }

        private void MenuQuiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Inicio().Show();
        }
    }
}
