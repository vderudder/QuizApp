namespace QuizApp.UI
{
    partial class SesionQuiz
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
            components = new System.ComponentModel.Container();
            labelTiempo = new Label();
            sesionTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labelTiempo
            // 
            labelTiempo.AutoSize = true;
            labelTiempo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelTiempo.Location = new Point(12, 166);
            labelTiempo.Name = "labelTiempo";
            labelTiempo.Size = new Size(86, 28);
            labelTiempo.TabIndex = 0;
            labelTiempo.Text = "00:00.00";
            // 
            // sesionTimer
            // 
            sesionTimer.Enabled = true;
            sesionTimer.Tick += sesionTimer_Tick;
            // 
            // SesionQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelTiempo);
            Name = "SesionQuiz";
            Text = "SesionQuiz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTiempo;
        private System.Windows.Forms.Timer sesionTimer;
    }
}