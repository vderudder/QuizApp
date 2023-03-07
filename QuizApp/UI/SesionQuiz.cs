using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QuizApp.UI
{
    public partial class SesionQuiz : Form
    {
        public SesionQuiz()
        {
            InitializeComponent();

            var preguntaFacade = new Facade.PreguntaFacade();
            var preguntas = preguntaFacade.getPreguntas();
            for (int i = 0; i < preguntas.Length; i++)
            {
                var label = new Label();
                label.Location = new Point(300, i * 100);
                label.Text = preguntas[i];
                this.Controls.Add(label);

                var groupBox = new System.Windows.Forms.GroupBox();
                groupBox.Location = new Point(300, i * 120);
                groupBox.AutoSize = true;
                groupBox.Text = "";

                var radioButton1 = new System.Windows.Forms.RadioButton();
                radioButton1.Text = "Soy la correcta";
                radioButton1.Top = 50;
                radioButton1.Left = 50;

                var radioButton2 = new System.Windows.Forms.RadioButton();
                radioButton2.Text = "Soy la incorrecta 1";
                radioButton2.Top = 100;
                radioButton2.Left = 50;

                var radioButton3 = new System.Windows.Forms.RadioButton();
                radioButton3.Text = "Soy la incorrecta 2";
                radioButton3.Top = 150;
                radioButton3.Left = 50;


                groupBox.Controls.Add(radioButton1);
                groupBox.Controls.Add(radioButton2);
                groupBox.Controls.Add(radioButton3);

                Controls.Add(groupBox);


            }


        }
    }
}
