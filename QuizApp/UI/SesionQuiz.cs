using Quizzify.Facade;
using Quizzify.IO;
using System.Data;
using System.Diagnostics;

namespace QuizApp.UI
{
    internal partial class SesionQuiz : Form
    {
        private SesionFacade iSesionFacade = Contexto.Instancia.SesionFacade;

        private Stopwatch iStopwatch = new Stopwatch();

        private string iNombreUsuario;
        private List<PreguntaDTO> iPreguntas;

        private Dictionary<PreguntaDTO, GroupBox> iGrupoPregRes = new Dictionary<PreguntaDTO, GroupBox>();

        public SesionQuiz(string pNombreUsuario, List<PreguntaDTO> pPreguntas)
        {
            InitializeComponent();

            // Cambia el cursor mientras espera
            Cursor.Current = Cursors.WaitCursor;

            int groupMarginTop = 20;
            int nextGroupY = groupMarginTop;

            // Guarda los valores de los parametros
            iPreguntas = pPreguntas;
            iNombreUsuario = pNombreUsuario;

            labelTiempo.Location = new Point(this.Location.X + this.Width / 2 - labelTiempo.Width / 2, 16);

            // Renderizar cada grupo de pregunta-respuestas
            for (int i = 0; i < iPreguntas.Count; i++)
            {
                // Guardo la pregunta temporalmente
                PreguntaDTO preg = iPreguntas[i];

                // Renderizar group box que contiene la pregunta y sus respuestas
                GroupBox grupoRespuestas = new GroupBox();
                grupoRespuestas.Location = new Point(20, nextGroupY);
                grupoRespuestas.Width = 500;
                grupoRespuestas.Text = preg.Nombre;


                // Desordenar las respuestas
                Random random = new Random();
                var respuestasDesordenadas = preg.Incorrectas.Append(preg.Correcta).OrderBy(x => random.Next()).ToArray();

                // Chequear si tiene mas de dos respuestas setear la altura del groupbox
                if (respuestasDesordenadas.Length > 2) { grupoRespuestas.Height = 190; } else { grupoRespuestas.Height = 110; }

                // Incrementar la altura del groupbox con un margen para renderizar el proximo groupbox
                nextGroupY = nextGroupY + grupoRespuestas.Height + groupMarginTop;

                // Renderizar las respuestas con radios
                for (int j = 0; j < respuestasDesordenadas.Length; j++)
                {
                    RadioButton radioButton = new RadioButton();
                    radioButton.Text = respuestasDesordenadas[j];
                    radioButton.Top = 36 * (j + 1);
                    radioButton.Left = 20;
                    radioButton.AutoSize = true;

                    grupoRespuestas.Controls.Add(radioButton);
                }

                containerPreguntas.Controls.Add(grupoRespuestas);
                iGrupoPregRes.Add(preg, grupoRespuestas);

            }


            // Comienza el cronometro visual
            iStopwatch.Start();
            // Comienza el contador del dominio
            iSesionFacade.IniciarTiempo();
        }

        private void BotonFinalizar_Click(object sender, EventArgs e)
        {
            // Cambia el cursor mientras espera
            Cursor.Current = Cursors.WaitCursor;

            List<PreguntaYRespuestaDTO> pregResElegidas = new List<PreguntaYRespuestaDTO>();

            // Fija el texto del radio button seleccionado para esa pregunta
            for (int i = 0; i < iGrupoPregRes.Count; i++)
            {
                var checkedRadio = iGrupoPregRes.ElementAt(i).Value.Controls.OfType<RadioButton>().FirstOrDefault((r) => r.Checked);

                // Si hay preguntas sin responder
                if (checkedRadio == null)
                {
                    MessageBox.Show("Please, answer all the questions", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    // Salir de este metodo
                    return;
                }

                PreguntaYRespuestaDTO pregRes = new PreguntaYRespuestaDTO { Pregunta = iGrupoPregRes.ElementAt(i).Key, Respuesta = checkedRadio.Text };
                pregResElegidas.Add(pregRes);
            }

            // Detiene el cronometro
            iStopwatch.Stop();

            try
            {
                // Guarda la sesion en BD
                var sesionActual = iSesionFacade.FinalizarSesion(pregResElegidas, iNombreUsuario);

                // Cierra la ventana actual
                this.Hide();

                // Abre la ventana de resultado pasandole la sesion actual
                new UI.PuntajeQuiz(sesionActual).Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong. Try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
                    
        }

        private void SesionTimer_Tick(object sender, EventArgs e)
        {
            labelTiempo.Text = "Time: " + iStopwatch.Elapsed.ToString("mm\\:ss\\.ff");
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

        private void SesionQuiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Inicio().Show();
        }
    }
}
