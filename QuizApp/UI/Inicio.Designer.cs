﻿namespace QuizApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            botonJugar = new Button();
            botonAdministrar = new Button();
            botonRanking = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // botonJugar
            // 
            botonJugar.Anchor = AnchorStyles.None;
            botonJugar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            botonJugar.ForeColor = Color.FromArgb(240, 31, 31);
            botonJugar.Location = new Point(113, 129);
            botonJugar.Name = "botonJugar";
            botonJugar.Size = new Size(118, 50);
            botonJugar.TabIndex = 0;
            botonJugar.Text = "PLAY";
            botonJugar.UseVisualStyleBackColor = true;
            botonJugar.Click += botonJugar_Click;
            // 
            // botonAdministrar
            // 
            botonAdministrar.BackColor = Color.Transparent;
            botonAdministrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            botonAdministrar.ForeColor = Color.FromArgb(64, 64, 64);
            botonAdministrar.Location = new Point(198, 269);
            botonAdministrar.Name = "botonAdministrar";
            botonAdministrar.Size = new Size(124, 56);
            botonAdministrar.TabIndex = 1;
            botonAdministrar.Text = "QUESTION MANAGER";
            botonAdministrar.UseVisualStyleBackColor = false;
            botonAdministrar.Click += botonAdministrar_Click;
            // 
            // botonRanking
            // 
            botonRanking.BackColor = SystemColors.ButtonFace;
            botonRanking.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            botonRanking.ForeColor = Color.FromArgb(64, 64, 64);
            botonRanking.Location = new Point(293, 135);
            botonRanking.Name = "botonRanking";
            botonRanking.Size = new Size(118, 43);
            botonRanking.TabIndex = 2;
            botonRanking.Text = "RANKING";
            botonRanking.UseVisualStyleBackColor = false;
            botonRanking.Click += botonRanking_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(169, 58);
            label1.Name = "label1";
            label1.Size = new Size(174, 21);
            label1.TabIndex = 3;
            label1.Text = "Welcome to Quizzify!";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(61, 238);
            label2.Name = "label2";
            label2.Size = new Size(400, 2);
            label2.TabIndex = 4;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(505, 348);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(botonRanking);
            Controls.Add(botonAdministrar);
            Controls.Add(botonJugar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quizzify";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonJugar;
        private Button botonAdministrar;
        private Button botonRanking;
        private Label label1;
        private Label label2;
    }
}