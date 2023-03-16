using QuizApp.Dominio;
using QuizApp.Dominio.Util;
using QuizApp.Facade;
using System.Data;
using System.Diagnostics;

namespace QuizApp.UI
{
    internal partial class SesionQuiz : Form
    {
        private SesionFacade iSesionFacade = Contexto.iInstancia.iSesionFacade;

        private Stopwatch iStopwatch = new Stopwatch();

        private string iNombreUsuario;
        private List<Pregunta> iPreguntas;

        private Dictionary<Pregunta, GroupBox> iGrupoPregRes = new Dictionary<Pregunta, GroupBox>();


        public SesionQuiz(string pNombreUsuario, List<Pregunta> pPreguntas)
        {
            InitializeComponent();

            int pregMarginTop = 40;
            int groupMarginTop = 20;
            int pregBoxMaxHeight = 220;

            // Guarda los valores de los parametros
            iPreguntas = pPreguntas;
            iNombreUsuario = pNombreUsuario;

            // Renderizar cada grupo de pregunta-respuestas
            for (int i = 0; i < iPreguntas.Count; i++)
            {
                Pregunta preg = iPreguntas[i];

                GroupBox grupoRespuestas = new GroupBox();
                int grupoY = groupMarginTop + pregBoxMaxHeight * i;
                grupoRespuestas.Location = new Point(300, grupoY);
                grupoRespuestas.AutoSize = true;
                grupoRespuestas.Text = preg.Nombre;

                // Desordenar las respuestas
                Random random = new Random();
                var respuestasDesordenadas = preg.Incorrecta.Append(preg.Correcta).OrderBy(x => random.Next()).ToArray();

                for (int j = 0; j < respuestasDesordenadas.Length; j++)
                {
                    RadioButton radioButton = new RadioButton();
                    radioButton.Text = respuestasDesordenadas[j];
                    radioButton.Top = pregMarginTop * (j + 1);
                    radioButton.Left = 50;

                    grupoRespuestas.Controls.Add(radioButton);
                }

                Controls.Add(grupoRespuestas);
                iGrupoPregRes.Add(preg, grupoRespuestas);

            }

            Button botonFinalizar = new Button();
            botonFinalizar.Top = pregBoxMaxHeight * iPreguntas.Count + pregMarginTop;
            botonFinalizar.Text = "Finalizar";
            Controls.Add(botonFinalizar);
            botonFinalizar.Click += botonFinalizar_Click;

            // Comienza el cronometro
            iStopwatch.Start();
        }

        private void botonFinalizar_Click(object? sender, EventArgs e)
        {
            List<PreguntaYRespuesta> pregResElegidas = new List<PreguntaYRespuesta>();

            // Fija el texto del radio button seleccionado para esa pregunta
            for (int i = 0; i < iGrupoPregRes.Count; i++)
            {
                var checkedRadio = iGrupoPregRes.ElementAt(i).Value.Controls.OfType<RadioButton>().FirstOrDefault((r) => r.Checked);

                // Si hay preguntas sin responder
                if (checkedRadio == null)
                {
                    MessageBox.Show("Por favor responda todas las preguntas");

                    // Salir de este metodo
                    return;
                }

                PreguntaYRespuesta pregRes = new PreguntaYRespuesta(iGrupoPregRes.ElementAt(i).Key, checkedRadio.Text);
                pregResElegidas.Add(pregRes);
            }

            // Detiene el cronometro
            iStopwatch.Stop();
            // Obtiene el tiempo insumido en la sesion
            double tiempo = iStopwatch.Elapsed.TotalSeconds;

            // Se finaliza la sesion, calcula el puntaje
            var sesionActual = iSesionFacade.finalizarSesion(iNombreUsuario, tiempo, pregResElegidas);

            // Abre la ventana de resultado pasandole la sesion actual
            new UI.PuntajeQuiz(sesionActual).Show();

        }
        /// <summary>
        /// Muestra el cronometro de tiempo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sesionTimer_Tick(object sender, EventArgs e)
        {
            labelTiempo.Text = iStopwatch.Elapsed.ToString("mm\\:ss\\.ff");

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
