namespace SquadHub
{
    partial class UpdateStatsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbMatches;
        private System.Windows.Forms.ComboBox cmbPlayers;
        private System.Windows.Forms.NumericUpDown numMinutes;
        private System.Windows.Forms.NumericUpDown numGoals;
        private System.Windows.Forms.NumericUpDown numYellow;
        private System.Windows.Forms.NumericUpDown numRed;
        private System.Windows.Forms.Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbMatches = new System.Windows.Forms.ComboBox();
            this.cmbPlayers = new System.Windows.Forms.ComboBox();
            this.numMinutes = new System.Windows.Forms.NumericUpDown();
            this.numGoals = new System.Windows.Forms.NumericUpDown();
            this.numYellow = new System.Windows.Forms.NumericUpDown();
            this.numRed = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();

            System.Windows.Forms.Label lbl1 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lbl2 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lbl3 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lbl4 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lbl5 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lbl6 = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGoals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRed)).BeginInit();
            this.SuspendLayout();

            int[] y = { 20, 60, 100, 140, 180, 220 };

            lbl1.Text = "Матч:"; lbl1.Location = new System.Drawing.Point(20, y[0]);
            lbl2.Text = "Гравець:"; lbl2.Location = new System.Drawing.Point(20, y[1]);
            lbl3.Text = "Зіграно хвилин:"; lbl3.Location = new System.Drawing.Point(20, y[2]);
            lbl4.Text = "Голи:"; lbl4.Location = new System.Drawing.Point(20, y[3]);
            lbl5.Text = "Жовті картки:"; lbl5.Location = new System.Drawing.Point(20, y[4]);
            lbl6.Text = "Червоні картки:"; lbl6.Location = new System.Drawing.Point(20, y[5]);

            this.cmbMatches.Location = new System.Drawing.Point(140, y[0]); this.cmbMatches.Width = 200; this.cmbMatches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMatches.SelectedIndexChanged += new System.EventHandler(this.cmbMatches_SelectedIndexChanged);

            this.cmbPlayers.Location = new System.Drawing.Point(140, y[1]); this.cmbPlayers.Width = 200; this.cmbPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.numMinutes.Location = new System.Drawing.Point(140, y[2]); this.numMinutes.Width = 200; this.numMinutes.Maximum = 120;
            this.numGoals.Location = new System.Drawing.Point(140, y[3]); this.numGoals.Width = 200;
            this.numYellow.Location = new System.Drawing.Point(140, y[4]); this.numYellow.Width = 200; this.numYellow.Maximum = 2;
            this.numRed.Location = new System.Drawing.Point(140, y[5]); this.numRed.Width = 200; this.numRed.Maximum = 1;

            this.btnSave.Text = "Зберегти результати";
            this.btnSave.Location = new System.Drawing.Point(140, 260);
            this.btnSave.Size = new System.Drawing.Size(200, 40);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.ClientSize = new System.Drawing.Size(370, 320);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, this.cmbMatches, this.cmbPlayers, this.numMinutes, this.numGoals, this.numYellow, this.numRed, this.btnSave });
            this.Name = "UpdateStatsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Введення результатів матчу";
            this.Load += new System.EventHandler(this.UpdateStatsForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGoals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRed)).EndInit();
            this.ResumeLayout(false);
        }
    }
}