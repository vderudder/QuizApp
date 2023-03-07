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
    public partial class SesionQuiz : Form
    {
        public SesionQuiz()
        {
            InitializeComponent();

            labelPregunta.Text = "Cuanto es 2+2?";
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton3);

            Controls.Add(groupBox1);

            radioButton1.Text = "Soy la correcta";
            radioButton2.Text = "Soy la incorrecta 1";
            radioButton3.Text = "Soy la incorrecta 2";
        }
    }
}
