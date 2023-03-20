using QuizApp.Excepcion;
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
                    try
                    {
                        await Contexto.iInstancia.iAdminFacade.guardarPreguntasLocal(urlInput.Text);

                        MessageBox.Show("The questions were saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        if (ex is InvalidParameterException)
                        {
                            MessageBox.Show("There is an invalid parameter in this query", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else if (ex is NoResultException) 
                        {
                            MessageBox.Show("There are no questions for this query", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            MessageBox.Show("Something went wrong. Try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                        urlInput.Text = "";
                    }
                    
                }
                else
                {
                    // El link no tiene formato de url
                    MessageBox.Show("The URL address is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    urlInput.Text = "";

                }

            }
            else
            {
                // No se ha ingresado una url
                MessageBox.Show("You need to enter an URL address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

    }
}
