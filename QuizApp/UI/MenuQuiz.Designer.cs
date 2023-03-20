﻿namespace QuizApp.UI
{
    partial class MenuQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuQuiz));
            dificultadList = new ComboBox();
            categoriaList = new ComboBox();
            cantidadPreguntas = new NumericUpDown();
            botonIniciarQuiz = new Button();
            usuarioList = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)cantidadPreguntas).BeginInit();
            SuspendLayout();
            // 
            // dificultadList
            // 
            dificultadList.FormattingEnabled = true;
            dificultadList.Location = new Point(118, 195);
            dificultadList.Name = "dificultadList";
            dificultadList.Size = new Size(213, 23);
            dificultadList.TabIndex = 1;
            dificultadList.Text = "Select a difficulty";
            // 
            // categoriaList
            // 
            categoriaList.FormattingEnabled = true;
            categoriaList.Location = new Point(118, 146);
            categoriaList.Name = "categoriaList";
            categoriaList.Size = new Size(213, 23);
            categoriaList.TabIndex = 0;
            categoriaList.Text = "Select a category";
            // 
            // cantidadPreguntas
            // 
            cantidadPreguntas.Location = new Point(254, 248);
            cantidadPreguntas.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            cantidadPreguntas.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            cantidadPreguntas.Name = "cantidadPreguntas";
            cantidadPreguntas.Size = new Size(77, 23);
            cantidadPreguntas.TabIndex = 2;
            cantidadPreguntas.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // botonIniciarQuiz
            // 
            botonIniciarQuiz.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            botonIniciarQuiz.Location = new Point(171, 325);
            botonIniciarQuiz.Name = "botonIniciarQuiz";
            botonIniciarQuiz.Size = new Size(97, 44);
            botonIniciarQuiz.TabIndex = 3;
            botonIniciarQuiz.Text = "PLAY !";
            botonIniciarQuiz.UseVisualStyleBackColor = true;
            botonIniciarQuiz.Click += botonIniciarQuiz_Click;
            // 
            // usuarioList
            // 
            usuarioList.FormattingEnabled = true;
            usuarioList.Items.AddRange(new object[] { "Create new user" });
            usuarioList.Location = new Point(118, 98);
            usuarioList.Name = "usuarioList";
            usuarioList.Size = new Size(213, 23);
            usuarioList.TabIndex = 4;
            usuarioList.Text = "Select your user";
            usuarioList.SelectionChangeCommitted += usuarioList_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 250);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 5;
            label1.Text = "Number of questions";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(171, 39);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 6;
            label2.Text = "PLAY MENU";
            // 
            // MenuQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(usuarioList);
            Controls.Add(botonIniciarQuiz);
            Controls.Add(cantidadPreguntas);
            Controls.Add(dificultadList);
            Controls.Add(categoriaList);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MenuQuiz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quizzify";
            ((System.ComponentModel.ISupportInitialize)cantidadPreguntas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown cantidadPreguntas;
        private Button botonIniciarQuiz;
        private ComboBox categoriaList;
        private ComboBox dificultadList;
        private ComboBox usuarioList;
        private Label label1;
        private Label label2;
    }
}