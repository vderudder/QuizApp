namespace QuizApp
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            botonJugar = new Button();
            botonAdministrar = new Button();
            SuspendLayout();
            // 
            // botonJugar
            // 
            botonJugar.Location = new Point(319, 94);
            botonJugar.Name = "botonJugar";
            botonJugar.Size = new Size(75, 23);
            botonJugar.TabIndex = 0;
            botonJugar.Text = "JUGAR";
            botonJugar.UseVisualStyleBackColor = true;
            botonJugar.Click += botonJugar_Click;
            // 
            // botonAdministrar
            // 
            botonAdministrar.Location = new Point(301, 168);
            botonAdministrar.Name = "botonAdministrar";
            botonAdministrar.Size = new Size(112, 23);
            botonAdministrar.TabIndex = 1;
            botonAdministrar.Text = "ADMINISTRAR";
            botonAdministrar.UseVisualStyleBackColor = true;
            botonAdministrar.Click += botonAdministrar_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botonAdministrar);
            Controls.Add(botonJugar);
            Name = "Inicio";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button botonJugar;
        private Button botonAdministrar;
    }
}