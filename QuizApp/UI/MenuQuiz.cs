using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;

namespace QuizApp.UI
{
    public partial class MenuQuiz : Form
    {
        public static string iNombreUsuario;
        public MenuQuiz()
        {
            InitializeComponent();

            var preguntaFacade = new Facade.PreguntaFacade();
            var usuarioFacade = new Facade.UsuarioFacade();
            // Obtiene las categorias y dificultades
            var categorias = preguntaFacade.getCategorias();
            var dificultades = preguntaFacade.getDificultades();
            // Obtiene los usuarios
            var usuarios = usuarioFacade.getUsuarios();

            // Agrega a la lista del comboBox los elementos de la lista de categorias
            for (int i = 0; i < categorias.Count; i++)
            {
                categoriaList.Items.Add(categorias[i].Nombre);
            }

            // Agrega a la lista del comboBox los elementos de la lista de dificultades
            for (int i = 0; i < dificultades.Count; i++)
            {
                dificultadList.Items.Add(dificultades[i].Nombre);
            }

            // Agrega a la lista del comboBox los elementos de la lista de usuarios
            for (int i = 0; i < usuarios.Count; i++)
            {
                usuarioList.Items.Add(usuarios[i].NombreUsuario);
            }

        }

        private void botonIniciarQuiz_Click(object sender, EventArgs e)
        {
            new UI.SesionQuiz().Show();
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
            // Tomar el usuario seleccionado y guardarlo
            else
            {
                var index = senderComboBox.SelectedIndex;
                // Guardar el valor para pasarlo
                iNombreUsuario = senderComboBox.Items[index].ToString();
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
