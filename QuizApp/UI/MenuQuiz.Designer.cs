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
            ComboBox categoriaList;
            ComboBox dificultadList;
            cantidadPreguntas = new NumericUpDown();
            botonIniciarTrivia = new Button();
            categoriaList = new ComboBox();
            dificultadList = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)cantidadPreguntas).BeginInit();
            SuspendLayout();
            // 
            // categoriaList
            // 
            categoriaList.FormattingEnabled = true;
            categoriaList.Items.AddRange(new object[] { "Animales", "Deporte" });
            categoriaList.Location = new Point(292, 109);
            categoriaList.Name = "categoriaList";
            categoriaList.Size = new Size(159, 23);
            categoriaList.TabIndex = 0;
            categoriaList.Text = "Seleccione una categoria";
            categoriaList.SelectedIndexChanged += categoriaList_SelectedIndexChanged;
            // 
            // dificultadList
            // 
            dificultadList.FormattingEnabled = true;
            dificultadList.Items.AddRange(new object[] { "Facil", "Intermedio", "Dificil" });
            dificultadList.Location = new Point(292, 161);
            dificultadList.Name = "dificultadList";
            dificultadList.Size = new Size(159, 23);
            dificultadList.TabIndex = 1;
            dificultadList.Text = "Seleccione una dificultad";
            // 
            // cantidadPreguntas
            // 
            cantidadPreguntas.Location = new Point(292, 218);
            cantidadPreguntas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            cantidadPreguntas.Name = "cantidadPreguntas";
            cantidadPreguntas.Size = new Size(159, 23);
            cantidadPreguntas.TabIndex = 2;
            cantidadPreguntas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // botonIniciarTrivia
            // 
            botonIniciarTrivia.Location = new Point(332, 288);
            botonIniciarTrivia.Name = "botonIniciarTrivia";
            botonIniciarTrivia.Size = new Size(75, 23);
            botonIniciarTrivia.TabIndex = 3;
            botonIniciarTrivia.Text = "Comenzar";
            botonIniciarTrivia.UseVisualStyleBackColor = true;
            // 
            // MenuQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botonIniciarTrivia);
            Controls.Add(cantidadPreguntas);
            Controls.Add(dificultadList);
            Controls.Add(categoriaList);
            Name = "MenuQuiz";
            Text = "MenuQuiz";
            ((System.ComponentModel.ISupportInitialize)cantidadPreguntas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown cantidadPreguntas;
        private Button botonIniciarTrivia;
    }
}