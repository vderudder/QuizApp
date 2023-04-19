namespace QuizApp.UI
{
    partial class SesionQuiz
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SesionQuiz));
            sesionTimer = new System.Windows.Forms.Timer(components);
            labelTiempo = new Label();
            containerPreguntas = new Panel();
            botonFinalizar = new Button();
            SuspendLayout();
            // 
            // sesionTimer
            // 
            sesionTimer.Enabled = true;
            sesionTimer.Tick += sesionTimer_Tick;
            // 
            // labelTiempo
            // 
            labelTiempo.AutoSize = true;
            labelTiempo.FlatStyle = FlatStyle.Flat;
            labelTiempo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTiempo.ForeColor = Color.FromArgb(38, 70, 83);
            labelTiempo.Location = new Point(243, 9);
            labelTiempo.Name = "labelTiempo";
            labelTiempo.Size = new Size(120, 19);
            labelTiempo.TabIndex = 0;
            labelTiempo.Text = "Time: 00:00.00";
            // 
            // containerPreguntas
            // 
            containerPreguntas.AutoScroll = true;
            containerPreguntas.Location = new Point(12, 43);
            containerPreguntas.Name = "containerPreguntas";
            containerPreguntas.Size = new Size(602, 364);
            containerPreguntas.TabIndex = 1;
            // 
            // botonFinalizar
            // 
            botonFinalizar.BackColor = Color.FromArgb(228, 23, 68);
            botonFinalizar.FlatAppearance.BorderColor = Color.FromArgb(228, 23, 68);
            botonFinalizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 20, 60);
            botonFinalizar.FlatStyle = FlatStyle.Flat;
            botonFinalizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            botonFinalizar.ForeColor = Color.White;
            botonFinalizar.Location = new Point(253, 427);
            botonFinalizar.Name = "botonFinalizar";
            botonFinalizar.Size = new Size(110, 48);
            botonFinalizar.TabIndex = 2;
            botonFinalizar.Text = "FINISH";
            botonFinalizar.UseVisualStyleBackColor = false;
            botonFinalizar.Click += botonFinalizar_Click;
            // 
            // SesionQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(626, 487);
            Controls.Add(containerPreguntas);
            Controls.Add(botonFinalizar);
            Controls.Add(labelTiempo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SesionQuiz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quizzify";
            FormClosed += SesionQuiz_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer sesionTimer;
        private Label labelTiempo;
        private Panel containerPreguntas;
        private Button botonFinalizar;
    }
}