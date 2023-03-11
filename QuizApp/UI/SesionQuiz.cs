using QuizApp.Dominio;
using QuizApp.Dominio.Util;
using QuizApp.Facade;
using QuizApp.Storage;
using System.Data;
using System.Diagnostics;

namespace QuizApp.UI
{
    public partial class SesionQuiz : Form
    {
        private PreguntaFacade iPreguntaFacade = new PreguntaFacade();
        private SesionFacade iSesionFacade = new SesionFacade();

        private Stopwatch iStopwatch = new Stopwatch();

        private string iNombreUsuario = string.Empty;
        private Dictionary<Pregunta, GroupBox> iGrupoPregRes;

        public static SesionDTO iSesionActual;

        public SesionQuiz()
        {
            InitializeComponent();

            int pregMarginTop = 40;
            int groupMarginTop = 20;
            int pregBoxMaxHeight = 220;

            var preguntas = iPreguntaFacade.getPreguntas();
            var iGrupoPregRes = new Dictionary<Pregunta, GroupBox>();

            for (int i = 0; i < preguntas.Count; i++)
            {
                var preg = preguntas[i];

                var grupoRespuestas = new System.Windows.Forms.GroupBox();
                var grupoY = groupMarginTop + pregBoxMaxHeight * i;
                grupoRespuestas.Location = new Point(300, grupoY);
                grupoRespuestas.AutoSize = true;
                grupoRespuestas.Text = preg.Nombre;

                Random random = new Random();
                var respuestasDesordenadas = preg.Incorrecta.Append(preg.Correcta).OrderBy(x => random.Next()).ToArray();

                for (int j = 0; j < respuestasDesordenadas.Length; j++)
                {
                    var radioButton = new System.Windows.Forms.RadioButton();
                    radioButton.Text = respuestasDesordenadas[j];
                    radioButton.Top = pregMarginTop * (j + 1);
                    radioButton.Left = 50;

                    grupoRespuestas.Controls.Add(radioButton);
                }

                Controls.Add(grupoRespuestas);
                iGrupoPregRes.Add(preg, grupoRespuestas);

            }

            var botonFinalizar = new System.Windows.Forms.Button();
            botonFinalizar.Top = pregBoxMaxHeight * preguntas.Count + pregMarginTop;
            botonFinalizar.Text = "Finalizar";
            Controls.Add(botonFinalizar);
            botonFinalizar.Click += botonFinalizar_Click;

            // Comienza el cronometro
            iStopwatch.Start();
        }


        private void botonFinalizar_Click(object? sender, EventArgs e)
        {
            List<PreguntaYRespuesta> pregResElegidas = new List<PreguntaYRespuesta>();

            for (int i = 0; i < iGrupoPregRes.Count; i++)
            {
                var checkedRadio = iGrupoPregRes.ElementAt(i).Value.Controls.OfType<RadioButton>().FirstOrDefault((r) => r.Checked);

                if (checkedRadio == null)
                {
                    MessageBox.Show("Por favor responda todas las preguntas");

                    // Salir de este metodo
                    return;
                }
                
                var pregRes = new PreguntaYRespuesta(iGrupoPregRes.ElementAt(i).Key, checkedRadio.Text);
                pregResElegidas.Add(pregRes);
            }

            // Detiene el cronometro
            iStopwatch.Stop();
            // Obtiene el tiempo insumido en la sesion
            var tiempo = (int)iStopwatch.Elapsed.TotalSeconds;

            // usar facade para calcular el puntaje
            iSesionActual = iSesionFacade.finalizarSesion(iNombreUsuario, tiempo, pregResElegidas);

            new UI.PuntajeQuiz().Show();

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

    internal class PreguntaRespuesta
    {
        public string iPregunta;
        public string iRespuesta;

        public PreguntaRespuesta(string pPregunta, string pRespuesta)
        {
            this.iPregunta = pPregunta;
            this.iRespuesta = pRespuesta;
        }
    }
}
