namespace SquadHub
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLoadPlayers;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnMedical;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnUpdateStats;

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label lblFinance;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvPlayers = new DataGridView();
            topPanel = new Panel();
            lblTitle = new Label();
            btnAddPlayer = new Button();
            btnMedical = new Button();
            btnMatch = new Button();
            btnUpdateStats = new Button();
            txtSearch = new TextBox();
            cmbFilter = new ComboBox();
            lblFinance = new Label();
            btnReport = new Button();
            btnLoadPlayers = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPlayers).BeginInit();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPlayers
            // 
            dgvPlayers.AllowUserToAddRows = false;
            dgvPlayers.AllowUserToDeleteRows = false;
            dgvPlayers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPlayers.ColumnHeadersHeight = 29;
            dgvPlayers.Dock = DockStyle.Fill;
            dgvPlayers.Location = new Point(0, 130);
            dgvPlayers.Name = "dgvPlayers";
            dgvPlayers.ReadOnly = true;
            dgvPlayers.RowHeadersWidth = 51;
            dgvPlayers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlayers.Size = new Size(1050, 470);
            dgvPlayers.TabIndex = 0;
            // 
            // topPanel
            // 
            topPanel.Controls.Add(lblTitle);
            topPanel.Controls.Add(btnAddPlayer);
            topPanel.Controls.Add(btnMedical);
            topPanel.Controls.Add(btnMatch);
            topPanel.Controls.Add(btnUpdateStats);
            topPanel.Controls.Add(txtSearch);
            topPanel.Controls.Add(cmbFilter);
            topPanel.Controls.Add(lblFinance);
            topPanel.Controls.Add(btnReport);
            topPanel.Controls.Add(btnLoadPlayers);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1050, 130);
            topPanel.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(12, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(188, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "SquadHub";
            // 
            // btnAddPlayer
            // 
            btnAddPlayer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddPlayer.Location = new Point(311, 25);
            btnAddPlayer.Name = "btnAddPlayer";
            btnAddPlayer.Size = new Size(120, 40);
            btnAddPlayer.TabIndex = 1;
            btnAddPlayer.Text = "Додати гравця";
            btnAddPlayer.Click += btnAddPlayer_Click;
            // 
            // btnMedical
            // 
            btnMedical.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMedical.Location = new Point(440, 25);
            btnMedical.Name = "btnMedical";
            btnMedical.Size = new Size(76, 40);
            btnMedical.TabIndex = 2;
            btnMedical.Text = "Лазарет";
            btnMedical.Click += btnMedical_Click;
            // 
            // btnMatch
            // 
            btnMatch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMatch.Location = new Point(522, 25);
            btnMatch.Name = "btnMatch";
            btnMatch.Size = new Size(123, 40);
            btnMatch.TabIndex = 3;
            btnMatch.Text = "Створити матч";
            btnMatch.Click += btnMatch_Click;
            // 
            // btnUpdateStats
            // 
            btnUpdateStats.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdateStats.Location = new Point(651, 25);
            btnUpdateStats.Name = "btnUpdateStats";
            btnUpdateStats.Size = new Size(150, 40);
            btnUpdateStats.TabIndex = 4;
            btnUpdateStats.Text = "Ввести результати";
            btnUpdateStats.Click += btnUpdateStats_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(20, 80);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Пошук за ім'ям...";
            txtSearch.Size = new Size(250, 27);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += Filter_Changed;
            // 
            // cmbFilter
            // 
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Items.AddRange(new object[] { "Всі", "GK", "CB", "LB", "RB", "CM", "CAM", "LM", "RM", "RW", "LW", "ST" });
            cmbFilter.Location = new Point(311, 80);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(120, 28);
            cmbFilter.TabIndex = 6;
            cmbFilter.SelectedIndexChanged += Filter_Changed;
            // 
            // lblFinance
            // 
            lblFinance.AutoSize = true;
            lblFinance.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFinance.ForeColor = Color.Green;
            lblFinance.Location = new Point(440, 80);
            lblFinance.Name = "lblFinance";
            lblFinance.Size = new Size(276, 28);
            lblFinance.TabIndex = 7;
            lblFinance.Text = "Бюджет зарплат: 0 $ / тиж";
            // 
            // btnReport
            // 
            btnReport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReport.Location = new Point(807, 25);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(93, 40);
            btnReport.TabIndex = 8;
            btnReport.Text = "Статистика";
            btnReport.Click += btnReport_Click;
            // 
            // btnLoadPlayers
            // 
            btnLoadPlayers.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLoadPlayers.Location = new Point(906, 25);
            btnLoadPlayers.Name = "btnLoadPlayers";
            btnLoadPlayers.Size = new Size(132, 40);
            btnLoadPlayers.TabIndex = 9;
            btnLoadPlayers.Text = "Оновити список";
            btnLoadPlayers.Click += btnLoadPlayers_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(1050, 600);
            Controls.Add(dgvPlayers);
            Controls.Add(topPanel);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SquadHub - Football Manager";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPlayers).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ResumeLayout(false);
        }
    }
}