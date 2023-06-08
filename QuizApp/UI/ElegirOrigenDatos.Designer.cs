namespace Quizzify.UI
{
    partial class ElegirOrigenDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElegirOrigenDatos));
            subtitleLabel = new Label();
            tituloLabel = new Label();
            origenList = new ComboBox();
            botonContinuar = new Button();
            SuspendLayout();
            // 
            // subtitleLabel
            // 
            subtitleLabel.AutoSize = true;
            subtitleLabel.Location = new Point(184, 103);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(111, 15);
            subtitleLabel.TabIndex = 1;
            subtitleLabel.Text = "Select a data source";
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tituloLabel.ForeColor = Color.FromArgb(38, 70, 83);
            tituloLabel.Location = new Point(94, 45);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(325, 21);
            tituloLabel.TabIndex = 2;
            tituloLabel.Text = "Welcome to Quizzify's Question Manager";
            // 
            // origenList
            // 
            origenList.FormattingEnabled = true;
            origenList.Location = new Point(168, 133);
            origenList.Name = "origenList";
            origenList.Size = new Size(144, 23);
            origenList.TabIndex = 3;
            // 
            // botonContinuar
            // 
            botonContinuar.BackColor = Color.FromArgb(228, 23, 68);
            botonContinuar.FlatAppearance.BorderColor = Color.FromArgb(228, 23, 68);
            botonContinuar.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 20, 60);
            botonContinuar.FlatStyle = FlatStyle.Flat;
            botonContinuar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            botonContinuar.ForeColor = Color.White;
            botonContinuar.Location = new Point(198, 194);
            botonContinuar.Name = "botonContinuar";
            botonContinuar.Size = new Size(97, 44);
            botonContinuar.TabIndex = 4;
            botonContinuar.Text = "Continue";
            botonContinuar.UseVisualStyleBackColor = false;
            botonContinuar.Click += botonContinuar_Click;
            // 
            // ElegirOrigenDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 270);
            Controls.Add(botonContinuar);
            Controls.Add(origenList);
            Controls.Add(tituloLabel);
            Controls.Add(subtitleLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ElegirOrigenDatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quizzify";
            FormClosed += ElegirOrigenDatos_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label subtitleLabel;
        private Label tituloLabel;
        private ComboBox origenList;
        private Button botonContinuar;
    }
}