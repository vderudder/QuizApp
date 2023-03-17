using QuizApp.Dominio;
using QuizApp.Facade;


namespace QuizApp.UI
{
    public partial class MenuQuiz : Form
    {

        private PreguntaFacade iPreguntaFacade = Contexto.iInstancia.iPreguntaFacade;
        private UsuarioFacade iUsuarioFacade = Contexto.iInstancia.iUsuarioFacade;

        private string iNombreUsuario;

        private List<Pregunta> iPreguntas;
        private List<string> iCategorias;
        private List<string> iDificultades;
        private List<Usuario> iUsuarios;

        public MenuQuiz()
        {
            InitializeComponent();

            // Obtiene las categorias y dificultades
            iCategorias = iPreguntaFacade.getCategorias();
            iDificultades = iPreguntaFacade.getDificultades();
            // Obtiene los usuarios
            iUsuarios = iUsuarioFacade.getUsuarios();

            // Agrega a la lista del comboBox los elementos de la lista de categorias
            for (int i = 0; i < iCategorias.Count; i++)
            {
                categoriaList.Items.Add(iCategorias[i]);
            }

            // Agrega a la lista del comboBox los elementos de la lista de dificultades
            for (int i = 0; i < iDificultades.Count; i++)
            {
                // Mostrar la dificultad de una mejor manera
                dificultadList.Items.Add(iDificultades[i][0].ToString().ToUpper() + iDificultades[i].Substring(1));
            }

            // Agrega a la lista del comboBox los elementos de la lista de usuarios
            for (int i = 0; i < iUsuarios.Count; i++)
            {
                usuarioList.Items.Add(iUsuarios[i].NombreUsuario);
            }

        }

        private void botonIniciarQuiz_Click(object sender, EventArgs e)
        {
            // Fija si se seleccionaron todas las opciones
            if (dificultadList.SelectedIndex >= 0 && categoriaList.SelectedIndex >= 0 && usuarioList.SelectedIndex > 0 && cantidadPreguntas.Value > 0)
            {
                // Tomar los datos de los inputs
                iNombreUsuario = usuarioList.Text;

                string dificultad = dificultadList.Text.ToLower();

                string categoria = categoriaList.Text;

                int cantidadPreg = (int)cantidadPreguntas.Value;

                // Obtiene las preguntas filtradas
                iPreguntas = iPreguntaFacade.getPreguntas(dificultad, categoria, cantidadPreg);

                // Si hay preguntas, pasa a la siguiente ventana pasandole los datos de usuario y las preguntas
                if (iPreguntas.Count > 0)
                {
                    new UI.SesionQuiz(iNombreUsuario, iPreguntas).Show();
                }
                else
                {
                    MessageBox.Show("There are no questions for your selected options. Plase, choose other options", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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

            ventana.Text = "Nuevo usuario";
            tituloLabel.Text = "Escribe tu nombre de usuario";

            botonOk.Text = "Aceptar";
            botonCancelar.Text = "Cancelar";
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


    }
}
