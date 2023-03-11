namespace QuizApp.UI
{
    partial class RankingQuiz
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
            tituloLabel = new Label();
            SuspendLayout();
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tituloLabel.Location = new Point(306, 27);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(132, 21);
            tituloLabel.TabIndex = 0;
            tituloLabel.Text = "RANKING TOP 20";
            // 
            // RankingQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tituloLabel);
            Name = "RankingQuiz";
            Text = "RankingQuiz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloLabel;
    }
}