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
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(202, 40);
            label1.Name = "label1";
            label1.Size = new Size(325, 21);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Quizzify's Question Manager";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(82, 88);
            label2.Name = "label2";
            label2.Size = new Size(372, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter the URL address given by OpenTDB for the selected question set";
            // 
            // urlInput
            // 
            urlInput.Location = new Point(161, 136);
            urlInput.Name = "urlInput";
            urlInput.Size = new Size(443, 23);
            urlInput.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 139);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 3;
            label3.Text = "URL Address";
            // 
            // botonGuardar
            // 
            botonGuardar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            botonGuardar.Location = new Point(295, 210);
            botonGuardar.Name = "botonGuardar";
            botonGuardar.Size = new Size(107, 53);
            botonGuardar.TabIndex = 4;
            botonGuardar.Text = "SAVE";
            botonGuardar.UseVisualStyleBackColor = true;
            botonGuardar.Click += botonGuardar_Click;
            // 
            // AdministrarQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 305);
            Controls.Add(botonGuardar);
            Controls.Add(label3);
            Controls.Add(urlInput);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AdministrarQuiz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quizzify";
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