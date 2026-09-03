namespace SquadHub
{
    partial class MatchForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtOpponent;
        private System.Windows.Forms.DateTimePicker dtpMatchDate;
        private System.Windows.Forms.ComboBox cmbTactics;
        private System.Windows.Forms.Button btnCreateMatch;
        private System.Windows.Forms.GroupBox gbSquad;
        private System.Windows.Forms.ComboBox cmbPlayers;
        private System.Windows.Forms.Button btnAddPlayer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtOpponent = new System.Windows.Forms.TextBox();
            this.dtpMatchDate = new System.Windows.Forms.DateTimePicker();
            this.cmbTactics = new System.Windows.Forms.ComboBox();
            this.btnCreateMatch = new System.Windows.Forms.Button();
            this.gbSquad = new System.Windows.Forms.GroupBox();
            this.cmbPlayers = new System.Windows.Forms.ComboBox();
            this.btnAddPlayer = new System.Windows.Forms.Button();

            System.Windows.Forms.Label lbl1 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lbl2 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lbl3 = new System.Windows.Forms.Label();

            this.gbSquad.SuspendLayout();
            this.SuspendLayout();

            // Match Section
            lbl1.Text = "Суперник:"; lbl1.Location = new System.Drawing.Point(20, 20);
            lbl2.Text = "Дата матчу:"; lbl2.Location = new System.Drawing.Point(20, 60);
            lbl3.Text = "Тактика:"; lbl3.Location = new System.Drawing.Point(20, 100);

            this.txtOpponent.Location = new System.Drawing.Point(120, 20); this.txtOpponent.Width = 200;
            this.dtpMatchDate.Location = new System.Drawing.Point(120, 60); this.dtpMatchDate.Width = 200; this.dtpMatchDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cmbTactics.Location = new System.Drawing.Point(120, 100); this.cmbTactics.Width = 200; this.cmbTactics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.btnCreateMatch.Text = "Створити матч";
            this.btnCreateMatch.Location = new System.Drawing.Point(120, 140); this.btnCreateMatch.Size = new System.Drawing.Size(200, 35);
            this.btnCreateMatch.Click += new System.EventHandler(this.btnCreateMatch_Click);

            // Squad Section (початково вимкнена)
            this.gbSquad.Text = "Заявка гравців на матч";
            this.gbSquad.Location = new System.Drawing.Point(20, 190); this.gbSquad.Size = new System.Drawing.Size(300, 100);
            this.gbSquad.Enabled = false;

            this.cmbPlayers.Location = new System.Drawing.Point(20, 30); this.cmbPlayers.Width = 260; this.cmbPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.btnAddPlayer.Text = "Додати до складу";
            this.btnAddPlayer.Location = new System.Drawing.Point(20, 60); this.btnAddPlayer.Size = new System.Drawing.Size(260, 30);
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);

            this.gbSquad.Controls.Add(this.cmbPlayers);
            this.gbSquad.Controls.Add(this.btnAddPlayer);

            // Form
            this.ClientSize = new System.Drawing.Size(350, 310);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { lbl1, lbl2, lbl3, this.txtOpponent, this.dtpMatchDate, this.cmbTactics, this.btnCreateMatch, this.gbSquad });
            this.Name = "MatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Організація матчу";
            this.Load += new System.EventHandler(this.MatchForm_Load);

            this.gbSquad.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}