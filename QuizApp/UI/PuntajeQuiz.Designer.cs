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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuntajeQuiz));
            resultadosLabel = new Label();
            puntajeLabel = new Label();
            tiempoLabel = new Label();
            volverMenuButton = new Button();
            fechaLabel = new Label();
            salirButton = new Button();
            SuspendLayout();
            // 
            // resultadosLabel
            // 
            resultadosLabel.AutoSize = true;
            resultadosLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            resultadosLabel.Location = new Point(105, 42);
            resultadosLabel.Name = "resultadosLabel";
            resultadosLabel.Size = new Size(307, 21);
            resultadosLabel.TabIndex = 0;
            resultadosLabel.Text = "CONGRATS! THIS IS YOUR FINAL SCORE";
            // 
            // puntajeLabel
            // 
            puntajeLabel.AutoSize = true;
            puntajeLabel.Location = new Point(146, 135);
            puntajeLabel.Name = "puntajeLabel";
            puntajeLabel.Size = new Size(42, 15);
            puntajeLabel.TabIndex = 1;
            puntajeLabel.Text = "Score: ";
            // 
            // tiempoLabel
            // 
            tiempoLabel.AutoSize = true;
            tiempoLabel.Location = new Point(146, 174);
            tiempoLabel.Name = "tiempoLabel";
            tiempoLabel.Size = new Size(64, 15);
            tiempoLabel.TabIndex = 2;
            tiempoLabel.Text = "Time used:";
            // 
            // volverMenuButton
            // 
            volverMenuButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            volverMenuButton.Location = new Point(168, 260);
            volverMenuButton.Name = "volverMenuButton";
            volverMenuButton.Size = new Size(163, 47);
            volverMenuButton.TabIndex = 3;
            volverMenuButton.Text = "MAIN MENU";
            volverMenuButton.UseVisualStyleBackColor = true;
            volverMenuButton.Click += volverMenuButton_Click;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new Point(146, 96);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new Size(34, 15);
            fechaLabel.TabIndex = 4;
            fechaLabel.Text = "Date:";
            // 
            // salirButton
            // 
            salirButton.BackColor = SystemColors.ButtonFace;
            salirButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            salirButton.Location = new Point(204, 329);
            salirButton.Name = "salirButton";
            salirButton.Size = new Size(89, 32);
            salirButton.TabIndex = 5;
            salirButton.Text = "EXIT";
            salirButton.UseVisualStyleBackColor = false;
            salirButton.Click += salirButton_Click;
            // 
            // PuntajeQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 450);
            Controls.Add(salirButton);
            Controls.Add(fechaLabel);
            Controls.Add(volverMenuButton);
            Controls.Add(tiempoLabel);
            Controls.Add(puntajeLabel);
            Controls.Add(resultadosLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PuntajeQuiz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quizzify";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label resultadosLabel;
        private Label puntajeLabel;
        private Label tiempoLabel;
        private Button volverMenuButton;
        private Label fechaLabel;
        private Button salirButton;
    }
}