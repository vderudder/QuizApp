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
            button2 = new Button();
            SuspendLayout();
            // 
            // botonJugar
            // 
            botonJugar.Location = new Point(319, 94);
            botonJugar.Name = "botonJugar";
            botonJugar.Size = new Size(75, 23);
            botonJugar.TabIndex = 0;
            botonJugar.Text = "JUGAR";
            botonJugar.UseVisualStyleBackColor = true;
            botonJugar.Click += botonJugar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(301, 168);
            button2.Name = "button2";
            button2.Size = new Size(112, 23);
            button2.TabIndex = 1;
            button2.Text = "ADMINISTRAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(botonJugar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button botonJugar;
        private Button button2;
    }
}