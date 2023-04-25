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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RankingQuiz));
            tituloLabel = new Label();
            rankingTable = new TableLayoutPanel();
            fechaHeader = new Label();
            tiempoHeader = new Label();
            puntajeHeader = new Label();
            usuarioHeader = new Label();
            puestoHeader = new Label();
            noResultadoLabel = new Label();
            rankingTable.SuspendLayout();
            SuspendLayout();
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tituloLabel.ForeColor = Color.FromArgb(38, 70, 83);
            tituloLabel.Location = new Point(394, 37);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(127, 21);
            tituloLabel.TabIndex = 0;
            tituloLabel.Text = "Ranking Top 20";
            // 
            // rankingTable
            // 
            rankingTable.Anchor = AnchorStyles.None;
            rankingTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            rankingTable.ColumnCount = 5;
            rankingTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.7824688F));
            rankingTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.82182F));
            rankingTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9954147F));
            rankingTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.40029F));
            rankingTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            rankingTable.Controls.Add(fechaHeader, 4, 0);
            rankingTable.Controls.Add(tiempoHeader, 3, 0);
            rankingTable.Controls.Add(puntajeHeader, 2, 0);
            rankingTable.Controls.Add(usuarioHeader, 1, 0);
            rankingTable.Controls.Add(puestoHeader, 0, 0);
            rankingTable.ForeColor = Color.FromArgb(38, 70, 83);
            rankingTable.Location = new Point(142, 94);
            rankingTable.Name = "rankingTable";
            rankingTable.RowCount = 21;
            rankingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            rankingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            rankingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            rankingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            rankingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            rankingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            rankingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            rankingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            rankingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            rankingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            rankingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            rankingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            rankingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            rankingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            rankingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            rankingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            rankingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            rankingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            rankingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            rankingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            rankingTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            rankingTable.Size = new Size(619, 444);
            rankingTable.TabIndex = 1;
            // 
            // fechaHeader
            // 
            fechaHeader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            fechaHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            fechaHeader.Location = new Point(509, 1);
            fechaHeader.Name = "fechaHeader";
            fechaHeader.Size = new Size(106, 20);
            fechaHeader.TabIndex = 3;
            fechaHeader.Text = "Date";
            fechaHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tiempoHeader
            // 
            tiempoHeader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tiempoHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tiempoHeader.Location = new Point(386, 1);
            tiempoHeader.Name = "tiempoHeader";
            tiempoHeader.Size = new Size(116, 20);
            tiempoHeader.TabIndex = 2;
            tiempoHeader.Text = "Time (seconds)";
            tiempoHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // puntajeHeader
            // 
            puntajeHeader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            puntajeHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            puntajeHeader.Location = new Point(260, 1);
            puntajeHeader.Name = "puntajeHeader";
            puntajeHeader.Size = new Size(119, 20);
            puntajeHeader.TabIndex = 1;
            puntajeHeader.Text = "Score";
            puntajeHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usuarioHeader
            // 
            usuarioHeader.Anchor = AnchorStyles.None;
            usuarioHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            usuarioHeader.Location = new Point(74, 1);
            usuarioHeader.Name = "usuarioHeader";
            usuarioHeader.Size = new Size(179, 20);
            usuarioHeader.TabIndex = 0;
            usuarioHeader.Text = "User";
            usuarioHeader.TextAlign = ContentAlignment.MiddleCenter;
            usuarioHeader.UseMnemonic = false;
            // 
            // puestoHeader
            // 
            puestoHeader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            puestoHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            puestoHeader.Location = new Point(4, 1);
            puestoHeader.Name = "puestoHeader";
            puestoHeader.Size = new Size(63, 20);
            puestoHeader.TabIndex = 4;
            puestoHeader.Text = "Position";
            puestoHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // noResultadoLabel
            // 
            noResultadoLabel.AutoSize = true;
            noResultadoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            noResultadoLabel.ForeColor = Color.FromArgb(38, 70, 83);
            noResultadoLabel.Location = new Point(338, 74);
            noResultadoLabel.Name = "noResultadoLabel";
            noResultadoLabel.Size = new Size(236, 21);
            noResultadoLabel.TabIndex = 2;
            noResultadoLabel.Text = "! There are no sessions to show !";
            // 
            // RankingQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 605);
            Controls.Add(noResultadoLabel);
            Controls.Add(rankingTable);
            Controls.Add(tituloLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RankingQuiz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quizzify";
            FormClosed += RankingQuiz_FormClosed;
            rankingTable.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloLabel;
        private TableLayoutPanel rankingTable;
        private Label usuarioHeader;
        private Label puntajeHeader;
        private Label tiempoHeader;
        private Label fechaHeader;
        private Label puestoHeader;
        private Label noResultadoLabel;
    }
}