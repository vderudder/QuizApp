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
    public partial class PuntajeQuiz : Form
    {
        public PuntajeQuiz()
        {
            InitializeComponent();

            var sesion = SesionQuiz.iSesionActual;

            puntajeLabel.Text = "Puntaje: " + sesion.iPuntaje.ToString();
            tiempoLabel.Text = "Tiempo: " + sesion.iTiempo.ToString();
            fechaLabel.Text = "Fecha: " + sesion.iFecha.ToString();
        }

        private void volverMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
            SesionQuiz.ActiveForm.Close();
        }
    }
}
