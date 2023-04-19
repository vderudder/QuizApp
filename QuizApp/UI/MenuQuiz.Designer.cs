namespace QuizApp.UI
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
            preguntasLabel = new Label();
            tituloLabel = new Label();
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
            botonIniciarQuiz.BackColor = Color.FromArgb(228, 23, 68);
            botonIniciarQuiz.FlatAppearance.BorderColor = Color.FromArgb(228, 23, 68);
            botonIniciarQuiz.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 20, 60);
            botonIniciarQuiz.FlatStyle = FlatStyle.Flat;
            botonIniciarQuiz.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            botonIniciarQuiz.ForeColor = Color.White;
            botonIniciarQuiz.Location = new Point(171, 325);
            botonIniciarQuiz.Name = "botonIniciarQuiz";
            botonIniciarQuiz.Size = new Size(97, 44);
            botonIniciarQuiz.TabIndex = 3;
            botonIniciarQuiz.Text = "PLAY !";
            botonIniciarQuiz.UseVisualStyleBackColor = false;
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
            // preguntasLabel
            // 
            preguntasLabel.AutoSize = true;
            preguntasLabel.Location = new Point(118, 250);
            preguntasLabel.Name = "preguntasLabel";
            preguntasLabel.Size = new Size(119, 15);
            preguntasLabel.TabIndex = 5;
            preguntasLabel.Text = "Number of questions";
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tituloLabel.ForeColor = Color.FromArgb(38, 70, 83);
            tituloLabel.Location = new Point(135, 40);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(169, 21);
            tituloLabel.TabIndex = 6;
            tituloLabel.Text = "Quizzify's Play Menu";
            // 
            // MenuQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 424);
            Controls.Add(tituloLabel);
            Controls.Add(preguntasLabel);
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
            FormClosed += MenuQuiz_FormClosed;
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
        private Label preguntasLabel;
        private Label tituloLabel;
    }
}