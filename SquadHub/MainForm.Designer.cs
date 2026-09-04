namespace SquadHub
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.Button btnLoadPlayers;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvPlayers = new DataGridView();
            btnLoadPlayers = new Button();
            btnAddPlayer = new Button();
            topPanel = new Panel();
            btnReport = new Button();
            btnMatch = new Button();
            btnMedical = new Button();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPlayers).BeginInit();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPlayers
            // 
            dgvPlayers.AllowUserToAddRows = false;
            dgvPlayers.AllowUserToDeleteRows = false;
            dgvPlayers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlayers.Dock = DockStyle.Fill;
            dgvPlayers.Location = new Point(0, 80);
            dgvPlayers.Margin = new Padding(3, 4, 3, 4);
            dgvPlayers.Name = "dgvPlayers";
            dgvPlayers.ReadOnly = true;
            dgvPlayers.RowHeadersWidth = 51;
            dgvPlayers.RowTemplate.Height = 25;
            dgvPlayers.Size = new Size(914, 520);
            dgvPlayers.TabIndex = 1;
            // 
            // btnLoadPlayers
            // 
            btnLoadPlayers.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLoadPlayers.Location = new Point(742, 20);
            btnLoadPlayers.Margin = new Padding(3, 4, 3, 4);
            btnLoadPlayers.Name = "btnLoadPlayers";
            btnLoadPlayers.Size = new Size(138, 47);
            btnLoadPlayers.TabIndex = 0;
            btnLoadPlayers.Text = "Оновити список";
            btnLoadPlayers.UseVisualStyleBackColor = true;
            btnLoadPlayers.Click += btnLoadPlayers_Click;
            // 
            // btnAddPlayer
            // 
            btnAddPlayer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddPlayer.Location = new Point(610, 20);
            btnAddPlayer.Margin = new Padding(3, 4, 3, 4);
            btnAddPlayer.Name = "btnAddPlayer";
            btnAddPlayer.Size = new Size(126, 47);
            btnAddPlayer.TabIndex = 2;
            btnAddPlayer.Text = "Додати гравця";
            btnAddPlayer.UseVisualStyleBackColor = true;
            btnAddPlayer.Click += btnAddPlayer_Click;
            // 
            // topPanel
            // 
            topPanel.Controls.Add(btnReport);
            topPanel.Controls.Add(btnMatch);
            topPanel.Controls.Add(btnMedical);
            topPanel.Controls.Add(lblTitle);
            topPanel.Controls.Add(btnAddPlayer);
            topPanel.Controls.Add(btnLoadPlayers);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Margin = new Padding(3, 4, 3, 4);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(914, 80);
            topPanel.TabIndex = 0;
            // 
            // btnReport
            // 
            btnReport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReport.Location = new Point(267, 20);
            btnReport.Margin = new Padding(3, 4, 3, 4);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(121, 47);
            btnReport.TabIndex = 5;
            btnReport.Text = "Статистика";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnMatch
            // 
            btnMatch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMatch.Location = new Point(394, 21);
            btnMatch.Margin = new Padding(3, 4, 3, 4);
            btnMatch.Name = "btnMatch";
            btnMatch.Size = new Size(121, 47);
            btnMatch.TabIndex = 4;
            btnMatch.Text = "Створити матч";
            btnMatch.UseVisualStyleBackColor = true;
            btnMatch.Click += btnMatch_Click;
            // 
            // btnMedical
            // 
            btnMedical.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMedical.Location = new Point(521, 21);
            btnMedical.Margin = new Padding(3, 4, 3, 4);
            btnMedical.Name = "btnMedical";
            btnMedical.Size = new Size(83, 47);
            btnMedical.TabIndex = 3;
            btnMedical.Text = "Лазарет";
            btnMedical.UseVisualStyleBackColor = true;
            btnMedical.Click += btnMedical_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(14, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(226, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Склад Команди";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(dgvPlayers);
            Controls.Add(topPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SquadHub - Football Manager";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPlayers).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ResumeLayout(false);
        }
        private Button btnMedical;
        private Button btnMatch;
        private Button btnReport;
    }
}