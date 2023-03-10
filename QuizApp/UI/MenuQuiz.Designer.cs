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
            dificultadList = new ComboBox();
            categoriaList = new ComboBox();
            cantidadPreguntas = new NumericUpDown();
            botonIniciarQuiz = new Button();
            usuarioInput = new TextBox();
            ((System.ComponentModel.ISupportInitialize)cantidadPreguntas).BeginInit();
            SuspendLayout();
            // 
            // dificultadList
            // 
            dificultadList.FormattingEnabled = true;
            dificultadList.Location = new Point(292, 161);
            dificultadList.Name = "dificultadList";
            dificultadList.Size = new Size(159, 23);
            dificultadList.TabIndex = 1;
            dificultadList.Text = "Seleccione una dificultad";
            // 
            // categoriaList
            // 
            categoriaList.FormattingEnabled = true;
            categoriaList.Location = new Point(292, 112);
            categoriaList.Name = "categoriaList";
            categoriaList.Size = new Size(159, 23);
            categoriaList.TabIndex = 0;
            categoriaList.Text = "Seleccione una categoría";
            // 
            // cantidadPreguntas
            // 
            cantidadPreguntas.Location = new Point(292, 218);
            cantidadPreguntas.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            cantidadPreguntas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            cantidadPreguntas.Name = "cantidadPreguntas";
            cantidadPreguntas.Size = new Size(159, 23);
            cantidadPreguntas.TabIndex = 2;
            cantidadPreguntas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // botonIniciarQuiz
            // 
            botonIniciarQuiz.Location = new Point(332, 288);
            botonIniciarQuiz.Name = "botonIniciarQuiz";
            botonIniciarQuiz.Size = new Size(75, 23);
            botonIniciarQuiz.TabIndex = 3;
            botonIniciarQuiz.Text = "Comenzar";
            botonIniciarQuiz.UseVisualStyleBackColor = true;
            botonIniciarQuiz.Click += botonIniciarQuiz_Click;
            // 
            // usuarioInput
            // 
            usuarioInput.Location = new Point(292, 64);
            usuarioInput.Name = "usuarioInput";
            usuarioInput.PlaceholderText = "Escribe tu usuario";
            usuarioInput.Size = new Size(159, 23);
            usuarioInput.TabIndex = 4;
            // 
            // MenuQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(usuarioInput);
            Controls.Add(botonIniciarQuiz);
            Controls.Add(cantidadPreguntas);
            Controls.Add(dificultadList);
            Controls.Add(categoriaList);
            Name = "MenuQuiz";
            Text = "MenuQuiz";
            ((System.ComponentModel.ISupportInitialize)cantidadPreguntas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown cantidadPreguntas;
        private Button botonIniciarQuiz;
        private TextBox usuarioInput;
        private ComboBox categoriaList;
        private ComboBox dificultadList;
    }
}