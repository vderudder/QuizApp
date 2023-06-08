using QuizApp;
using QuizApp.UI;
using Quizzify.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizzify.UI
{
    public partial class ElegirOrigenDatos : Form
    {
        private PreguntaFacade iPreguntaFacade = Contexto.iInstancia.iPreguntaFacade;

        private List<string> iOrigenes;
        private string iOrigenActual;

        public ElegirOrigenDatos()
        {
            InitializeComponent();

            try
            {

                // Cambia el cursor mientras espera
                Cursor.Current = Cursors.WaitCursor;

                // Se obtienen los origenes
                iOrigenes = iPreguntaFacade.GetOrigenes();

                if (iOrigenes.Count == 0)
                {
                    // Si no hay origenes cargados
                    MessageBox.Show("There are no sources loaded", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    // Agrega a la lista del comboBox los elementos de la lista de origenes
                    for (int i = 0; i < iOrigenes.Count; i++)
                    {
                        origenList.Items.Add(iOrigenes[i]);
                    }

                }
            }

            catch
            {
                // Si sale mal, cierra la ventana
                MessageBox.Show("Something went wrong. Try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void otdbButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdministrarQuiz().Show();

        }

        private void ElegirOrigenDatos_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Inicio().Show();

        }

        private void botonContinuar_Click(object sender, EventArgs e)
        {

            // Fija si se seleccionaron todas las opciones
            if (origenList.SelectedIndex >= 0)
            {
                // Tomar el origen seleccionado de la lista
                iOrigenActual = origenList.Text;

                new AdministrarQuiz().Show();

                // Cerrar la ventana
                this.Hide();

            }
            // Faltan campos por seleccionar
            else
            {
                MessageBox.Show("Please, select a source", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
