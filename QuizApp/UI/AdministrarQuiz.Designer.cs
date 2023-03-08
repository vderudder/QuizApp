namespace QuizApp.UI
{
    partial class AdministrarQuiz
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
            label1 = new Label();
            label2 = new Label();
            urlInput = new TextBox();
            label3 = new Label();
            botonGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 45);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "ADMINISTRAR QUIZ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 89);
            label2.Name = "label2";
            label2.Size = new Size(527, 15);
            label2.TabIndex = 1;
            label2.Text = "Inserte en la caja de texto el link provisto por OpenTDB para el conjunto de preguntas seleccionado";
            // 
            // urlInput
            // 
            urlInput.Location = new Point(134, 136);
            urlInput.Name = "urlInput";
            urlInput.Size = new Size(475, 23);
            urlInput.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 139);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 3;
            label3.Text = "Link: ";
            // 
            // botonGuardar
            // 
            botonGuardar.Location = new Point(346, 257);
            botonGuardar.Name = "botonGuardar";
            botonGuardar.Size = new Size(75, 23);
            botonGuardar.TabIndex = 4;
            botonGuardar.Text = "GUARDAR";
            botonGuardar.UseVisualStyleBackColor = true;
            botonGuardar.Click += botonGuardar_Click;
            // 
            // AdministrarQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botonGuardar);
            Controls.Add(label3);
            Controls.Add(urlInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdministrarQuiz";
            Text = "AdministrarQuiz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox urlInput;
        private Label label3;
        private Button botonGuardar;
    }
}