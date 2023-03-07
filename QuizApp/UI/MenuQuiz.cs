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
        }

        private void categoriaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void botonIniciarQuiz_Click(object sender, EventArgs e)
        {
            new UI.SesionQuiz().Show();
        }
    }
}
