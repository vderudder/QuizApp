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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SesionQuiz));
            sesionTimer = new System.Windows.Forms.Timer(components);
            labelTiempo = new Label();
            panel1 = new Panel();
            botonFinalizar = new Button();
            SuspendLayout();
            // 
            // sesionTimer
            // 
            sesionTimer.Enabled = true;
            sesionTimer.Tick += sesionTimer_Tick;
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
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(177, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(473, 341);
            panel1.TabIndex = 1;
            // 
            // botonFinalizar
            // 
            botonFinalizar.Location = new Point(51, 374);
            botonFinalizar.Name = "botonFinalizar";
            botonFinalizar.Size = new Size(75, 23);
            botonFinalizar.TabIndex = 2;
            botonFinalizar.Text = "FINISH";
            botonFinalizar.UseVisualStyleBackColor = true;
            botonFinalizar.Click += botonFinalizar_Click;
            // 
            // SesionQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(botonFinalizar);
            Controls.Add(panel1);
            Controls.Add(labelTiempo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SesionQuiz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quizzify";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer sesionTimer;
        private Label labelTiempo;
        private Panel panel1;
        private Button botonFinalizar;
    }
}