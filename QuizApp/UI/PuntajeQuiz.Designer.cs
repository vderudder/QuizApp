namespace QuizApp.UI
{
    partial class PuntajeQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            resultadosLabel = new Label();
            puntajeLabel = new Label();
            tiempoLabel = new Label();
            volverMenuButton = new Button();
            fechaLabel = new Label();
            SuspendLayout();
            // 
            // resultadosLabel
            // 
            resultadosLabel.AutoSize = true;
            resultadosLabel.Location = new Point(327, 35);
            resultadosLabel.Name = "resultadosLabel";
            resultadosLabel.Size = new Size(75, 15);
            resultadosLabel.TabIndex = 0;
            resultadosLabel.Text = "RESULTADOS";
            // 
            // puntajeLabel
            // 
            puntajeLabel.AutoSize = true;
            puntajeLabel.Location = new Point(277, 134);
            puntajeLabel.Name = "puntajeLabel";
            puntajeLabel.Size = new Size(53, 15);
            puntajeLabel.TabIndex = 1;
            puntajeLabel.Text = "Puntaje: ";
            // 
            // tiempoLabel
            // 
            tiempoLabel.AutoSize = true;
            tiempoLabel.Location = new Point(277, 173);
            tiempoLabel.Name = "tiempoLabel";
            tiempoLabel.Size = new Size(106, 15);
            tiempoLabel.TabIndex = 2;
            tiempoLabel.Text = "Tiempo insumido: ";
            // 
            // volverMenuButton
            // 
            volverMenuButton.Location = new Point(300, 265);
            volverMenuButton.Name = "volverMenuButton";
            volverMenuButton.Size = new Size(134, 23);
            volverMenuButton.TabIndex = 3;
            volverMenuButton.Text = "VOLVER AL MENU";
            volverMenuButton.UseVisualStyleBackColor = true;
            volverMenuButton.Click += volverMenuButton_Click;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new Point(277, 95);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new Size(44, 15);
            fechaLabel.TabIndex = 4;
            fechaLabel.Text = "Fecha: ";
            // 
            // PuntajeQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(fechaLabel);
            Controls.Add(volverMenuButton);
            Controls.Add(tiempoLabel);
            Controls.Add(puntajeLabel);
            Controls.Add(resultadosLabel);
            Name = "PuntajeQuiz";
            Text = "PuntajeQuiz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label resultadosLabel;
        private Label puntajeLabel;
        private Label tiempoLabel;
        private Button volverMenuButton;
        private Label fechaLabel;
    }
}