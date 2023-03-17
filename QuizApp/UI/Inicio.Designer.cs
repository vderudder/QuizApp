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
            botonRanking = new Button();
            SuspendLayout();
            // 
            // botonJugar
            // 
            botonJugar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            botonJugar.Location = new Point(298, 82);
            botonJugar.Name = "botonJugar";
            botonJugar.Size = new Size(118, 50);
            botonJugar.TabIndex = 0;
            botonJugar.Text = "PLAY";
            botonJugar.UseVisualStyleBackColor = true;
            botonJugar.Click += botonJugar_Click;
            // 
            // botonAdministrar
            // 
            botonAdministrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            botonAdministrar.Location = new Point(298, 375);
            botonAdministrar.Name = "botonAdministrar";
            botonAdministrar.Size = new Size(124, 39);
            botonAdministrar.TabIndex = 1;
            botonAdministrar.Text = "MANAGE";
            botonAdministrar.UseVisualStyleBackColor = true;
            botonAdministrar.Click += botonAdministrar_Click;
            // 
            // botonRanking
            // 
            botonRanking.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            botonRanking.Location = new Point(298, 161);
            botonRanking.Name = "botonRanking";
            botonRanking.Size = new Size(118, 43);
            botonRanking.TabIndex = 2;
            botonRanking.Text = "RANKING";
            botonRanking.UseVisualStyleBackColor = true;
            botonRanking.Click += botonRanking_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(botonRanking);
            Controls.Add(botonAdministrar);
            Controls.Add(botonJugar);
            Name = "Inicio";
            Text = "Trivia Game";
            ResumeLayout(false);
        }

        #endregion

        private Button botonJugar;
        private Button botonAdministrar;
        private Button botonRanking;
    }
}