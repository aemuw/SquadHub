namespace SquadHubApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.Button btnLoadPlayers;
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
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.btnLoadPlayers = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();

            // topPanel
            this.topPanel.Controls.Add(this.lblTitle);
            this.topPanel.Controls.Add(this.btnLoadPlayers);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(800, 60);
            this.topPanel.TabIndex = 0;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(184, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Склад Команди";

            // btnLoadPlayers
            this.btnLoadPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadPlayers.Location = new System.Drawing.Point(620, 15);
            this.btnLoadPlayers.Name = "btnLoadPlayers";
            this.btnLoadPlayers.Size = new System.Drawing.Size(150, 35);
            this.btnLoadPlayers.TabIndex = 0;
            this.btnLoadPlayers.Text = "Оновити список";
            this.btnLoadPlayers.UseVisualStyleBackColor = true;
            this.btnLoadPlayers.Click += new System.EventHandler(this.btnLoadPlayers_Click);

            // dgvPlayers
            this.dgvPlayers.AllowUserToAddRows = false;
            this.dgvPlayers.AllowUserToDeleteRows = false;
            this.dgvPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlayers.Location = new System.Drawing.Point(0, 60);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.ReadOnly = true;
            this.dgvPlayers.RowTemplate.Height = 25;
            this.dgvPlayers.Size = new System.Drawing.Size(800, 390);
            this.dgvPlayers.TabIndex = 1;

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPlayers);
            this.Controls.Add(this.topPanel);
            this.Name = "MainForm";
            this.Text = "SquadHub - Football Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}