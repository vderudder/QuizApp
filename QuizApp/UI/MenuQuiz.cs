using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp.UI
{
    public partial class MenuQuiz : Form
    {
        public MenuQuiz()
        {
            InitializeComponent();

            var preguntaFacade = new Facade.PreguntaFacade();
            // Obtiene las categorias y dificultades
            var categorias = preguntaFacade.getCategorias();
            var dificultades = preguntaFacade.getDificultades();

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
        }

        private void botonIniciarQuiz_Click(object sender, EventArgs e)
        {
            new UI.SesionQuiz().Show();
        }
    }
}
