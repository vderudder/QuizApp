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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrarQuiz));
            tituloLabel = new Label();
            subtituloLabel = new Label();
            urlInput = new TextBox();
            urlLabel = new Label();
            botonGuardar = new Button();
            SuspendLayout();
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tituloLabel.ForeColor = Color.FromArgb(38, 70, 83);
            tituloLabel.Location = new Point(202, 40);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(325, 21);
            tituloLabel.TabIndex = 0;
            tituloLabel.Text = "Welcome to Quizzify's Question Manager";
            // 
            // subtituloLabel
            // 
            subtituloLabel.AutoSize = true;
            subtituloLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            subtituloLabel.Location = new Point(82, 88);
            subtituloLabel.Name = "subtituloLabel";
            subtituloLabel.Size = new Size(302, 15);
            subtituloLabel.TabIndex = 1;
            subtituloLabel.Text = "Enter the URL address given for the selected question set";
            // 
            // urlInput
            // 
            urlInput.Location = new Point(161, 136);
            urlInput.Name = "urlInput";
            urlInput.Size = new Size(443, 23);
            urlInput.TabIndex = 2;
            // 
            // urlLabel
            // 
            urlLabel.AutoSize = true;
            urlLabel.Location = new Point(82, 139);
            urlLabel.Name = "urlLabel";
            urlLabel.Size = new Size(73, 15);
            urlLabel.TabIndex = 3;
            urlLabel.Text = "URL Address";
            // 
            // botonGuardar
            // 
            botonGuardar.BackColor = Color.FromArgb(228, 23, 68);
            botonGuardar.FlatAppearance.BorderColor = Color.FromArgb(228, 23, 68);
            botonGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 20, 60);
            botonGuardar.FlatStyle = FlatStyle.Flat;
            botonGuardar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            botonGuardar.ForeColor = Color.White;
            botonGuardar.Location = new Point(308, 218);
            botonGuardar.Name = "botonGuardar";
            botonGuardar.Size = new Size(96, 46);
            botonGuardar.TabIndex = 4;
            botonGuardar.Text = "SAVE";
            botonGuardar.UseVisualStyleBackColor = false;
            botonGuardar.Click += BotonGuardar_Click;
            // 
            // AdministrarQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 305);
            Controls.Add(botonGuardar);
            Controls.Add(urlLabel);
            Controls.Add(urlInput);
            Controls.Add(subtituloLabel);
            Controls.Add(tituloLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AdministrarQuiz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quizzify";
            FormClosed += AdministrarQuiz_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloLabel;
        private Label subtituloLabel;
        private TextBox urlInput;
        private Label urlLabel;
        private Button botonGuardar;
    }
}