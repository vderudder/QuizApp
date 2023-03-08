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
    public partial class AdministrarQuiz : Form
    {
        public AdministrarQuiz()
        {
            InitializeComponent();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (urlInput.Text.Length > 0)
            {
                // Hacer la request y persistir la response
                MessageBox.Show("Deberia hacer la request");
            }
            else
            {
                // Tirar cartel de error, que tiene que poner una url
                MessageBox.Show("Deberia mostrar cartel de error");

            }
        }

    }
}
