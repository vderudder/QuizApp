using QuizApp.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp.UI
{
    public partial class AdministrarQuiz : Form
    {
        public AdministrarQuiz()
        {
            InitializeComponent();
        }

        private async void botonGuardar_Click(object sender, EventArgs e)
        {
            if (urlInput.Text.Length > 0)
            {
                if (Uri.IsWellFormedUriString(urlInput.Text, UriKind.Absolute))
                {
                    await Contexto.iInstancia.iAdminFacade.getPreguntas(urlInput.Text);

                }
                else
                {
                    // Tirar cartel de error, que tiene que poner una url
                    MessageBox.Show("The URL address is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                // Tirar cartel de error, que tiene que poner una url
                MessageBox.Show("You need to insert an URL address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

    }
}
