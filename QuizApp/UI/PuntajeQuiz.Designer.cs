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
            tituloLabel = new Label();
            puntajeLabel = new Label();
            tiempoLabel = new Label();
            volverMenuButton = new Button();
            fechaLabel = new Label();
            salirButton = new Button();
            resultadosLabel = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tituloLabel.ForeColor = Color.FromArgb(38, 70, 83);
            tituloLabel.Location = new Point(141, 40);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(250, 21);
            tituloLabel.TabIndex = 0;
            tituloLabel.Text = "Thank you for playing Quizzify!";
            // 
            // puntajeLabel
            // 
            puntajeLabel.AutoSize = true;
            puntajeLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            puntajeLabel.Location = new Point(141, 174);
            puntajeLabel.Name = "puntajeLabel";
            puntajeLabel.Size = new Size(53, 20);
            puntajeLabel.TabIndex = 1;
            puntajeLabel.Text = "Score: ";
            // 
            // tiempoLabel
            // 
            tiempoLabel.AutoSize = true;
            tiempoLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tiempoLabel.Location = new Point(141, 213);
            tiempoLabel.Name = "tiempoLabel";
            tiempoLabel.Size = new Size(80, 20);
            tiempoLabel.TabIndex = 2;
            tiempoLabel.Text = "Time used:";
            // 
            // volverMenuButton
            // 
            volverMenuButton.BackColor = Color.FromArgb(228, 23, 68);
            volverMenuButton.FlatAppearance.BorderColor = Color.FromArgb(228, 23, 68);
            volverMenuButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 20, 60);
            volverMenuButton.FlatStyle = FlatStyle.Flat;
            volverMenuButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            volverMenuButton.ForeColor = Color.White;
            volverMenuButton.Location = new Point(186, 312);
            volverMenuButton.Name = "volverMenuButton";
            volverMenuButton.Size = new Size(140, 45);
            volverMenuButton.TabIndex = 3;
            volverMenuButton.Text = "MAIN MENU";
            volverMenuButton.UseVisualStyleBackColor = false;
            volverMenuButton.Click += VolverMenuButton_Click;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            fechaLabel.Location = new Point(141, 135);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new Size(44, 20);
            fechaLabel.TabIndex = 4;
            fechaLabel.Text = "Date:";
            // 
            // salirButton
            // 
            salirButton.BackColor = SystemColors.ButtonFace;
            salirButton.FlatAppearance.BorderColor = Color.FromArgb(228, 23, 68);
            salirButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(253, 233, 238);
            salirButton.FlatStyle = FlatStyle.Flat;
            salirButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            salirButton.ForeColor = Color.FromArgb(228, 23, 68);
            salirButton.Location = new Point(209, 376);
            salirButton.Name = "salirButton";
            salirButton.Size = new Size(89, 32);
            salirButton.TabIndex = 5;
            salirButton.Text = "EXIT";
            salirButton.UseVisualStyleBackColor = false;
            salirButton.Click += SalirButton_Click;
            // 
            // resultadosLabel
            // 
            resultadosLabel.AutoSize = true;
            resultadosLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            resultadosLabel.ForeColor = Color.FromArgb(38, 70, 83);
            resultadosLabel.Location = new Point(173, 85);
            resultadosLabel.Name = "resultadosLabel";
            resultadosLabel.Size = new Size(170, 21);
            resultadosLabel.TabIndex = 6;
            resultadosLabel.Text = "This is your final score";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.FromArgb(38, 70, 83);
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.ForeColor = Color.FromArgb(38, 70, 83);
            label2.Location = new Point(57, 274);
            label2.Name = "label2";
            label2.Size = new Size(400, 2);
            label2.TabIndex = 7;
            // 
            // PuntajeQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 450);
            Controls.Add(label2);
            Controls.Add(resultadosLabel);
            Controls.Add(salirButton);
            Controls.Add(fechaLabel);
            Controls.Add(volverMenuButton);
            Controls.Add(tiempoLabel);
            Controls.Add(puntajeLabel);
            Controls.Add(tituloLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PuntajeQuiz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quizzify";
            FormClosed += PuntajeQuiz_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloLabel;
        private Label puntajeLabel;
        private Label tiempoLabel;
        private Button volverMenuButton;
        private Label fechaLabel;
        private Button salirButton;
        private Label resultadosLabel;
        private Label label2;
    }
}