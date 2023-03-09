using System.Data;
using System.Diagnostics;

namespace QuizApp.UI
{
    public partial class SesionQuiz : Form
    {
        private Stopwatch iStopwatch = new Stopwatch();
        public SesionQuiz()
        {
            InitializeComponent();

            // Comienza el cronometro
            iStopwatch.Start();

            var preguntaFacade = new Facade.PreguntaFacade();
            var preguntas = preguntaFacade.getPreguntas();
            for (int i = 0; i < preguntas.Count; i++)
            {
                var preg = preguntas[i];

                var pregunta = new Label();
                pregunta.Location = new Point(300, i * 100);
                pregunta.Text = preguntas[i].Nombre;
                Controls.Add(pregunta);

                var grupoRespuestas = new System.Windows.Forms.GroupBox();
                grupoRespuestas.Location = new Point(300, i * 120);
                grupoRespuestas.AutoSize = true;
                grupoRespuestas.Text = "";

                Random random = new Random();
                var respuestasDesordenadas = preg.Incorrecta.Append(preg.Correcta).OrderBy(x => random.Next()).ToArray();

                for (int j = 0; j < respuestasDesordenadas.Length; j++)
                {
                    var radioButton = new System.Windows.Forms.RadioButton();
                    radioButton.Text = respuestasDesordenadas[j];
                    radioButton.Top = 50 * (j + 1);
                    radioButton.Left = 50;

                    grupoRespuestas.Controls.Add(radioButton);
                }

                Controls.Add(grupoRespuestas);



            }

            var botonFinalizar = new System.Windows.Forms.Button();
            botonFinalizar.Text = "Finalizar";
            Controls.Add(botonFinalizar);
            botonFinalizar.Click += botonFinalizar_Click;


        }

        private void botonFinalizar_Click(object? sender, EventArgs e)
        {
            new UI.PuntajeQuiz().Show();
            // Detiene el cronometro
            iStopwatch.Stop();

            Debug.WriteLine("tiempo: " + iStopwatch.Elapsed.TotalSeconds);


        }
        /// <summary>
        /// Muestra el cronometro de tiempo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sesionTimer_Tick(object sender, EventArgs e)
        {
            this.labelTiempo.Text = iStopwatch.Elapsed.ToString("mm\\:ss\\.ff");

        }
    }
}
