namespace SquadHub
{
    partial class EditPlayerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.NumericUpDown numRating;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.NumericUpDown numWage;
        private System.Windows.Forms.DateTimePicker dtpContractStart;
        private System.Windows.Forms.DateTimePicker dtpContractEnd;
        private System.Windows.Forms.NumericUpDown numReleaseClause;
        private System.Windows.Forms.Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.numRating = new System.Windows.Forms.NumericUpDown();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.numWage = new System.Windows.Forms.NumericUpDown();
            this.dtpContractStart = new System.Windows.Forms.DateTimePicker();
            this.dtpContractEnd = new System.Windows.Forms.DateTimePicker();
            this.numReleaseClause = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            System.Windows.Forms.Label lbl1 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lbl2 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lbl3 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lbl4 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lbl5 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lbl6 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lbl7 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lbl8 = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.numRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReleaseClause)).BeginInit();
            this.SuspendLayout();

            int[] y = { 20, 60, 100, 140, 180, 220, 260, 300 };

            lbl1.Text = "ПІБ Гравця:"; lbl1.Location = new System.Drawing.Point(20, y[0]);
            lbl2.Text = "Дата нар.:"; lbl2.Location = new System.Drawing.Point(20, y[1]);
            lbl3.Text = "Рейтинг (1-99):"; lbl3.Location = new System.Drawing.Point(20, y[2]);
            lbl4.Text = "Позиція:"; lbl4.Location = new System.Drawing.Point(20, y[3]);
            lbl5.Text = "Зарплата/тиж:"; lbl5.Location = new System.Drawing.Point(20, y[4]);
            lbl6.Text = "Старт контракту:"; lbl6.Location = new System.Drawing.Point(20, y[5]);
            lbl7.Text = "Кінець контракту:"; lbl7.Location = new System.Drawing.Point(20, y[6]);
            lbl8.Text = "Відступні:"; lbl8.Location = new System.Drawing.Point(20, y[7]);

            this.txtFullName.Location = new System.Drawing.Point(140, y[0]); this.txtFullName.Width = 200;
            this.dtpDOB.Location = new System.Drawing.Point(140, y[1]); this.dtpDOB.Width = 200; this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.numRating.Location = new System.Drawing.Point(140, y[2]); this.numRating.Width = 200; this.numRating.Minimum = 1; this.numRating.Maximum = 99;
            this.cmbPosition.Location = new System.Drawing.Point(140, y[3]); this.cmbPosition.Width = 200; this.cmbPosition.Items.AddRange(new object[] { "GK", "CB", "LB", "RB", "CM", "CAM", "LM", "RM", "RW", "LW", "ST" });

            this.numWage.Location = new System.Drawing.Point(140, y[4]); this.numWage.Width = 200; this.numWage.Maximum = 1000000;
            this.dtpContractStart.Location = new System.Drawing.Point(140, y[5]); this.dtpContractStart.Width = 200; this.dtpContractStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpContractEnd.Location = new System.Drawing.Point(140, y[6]); this.dtpContractEnd.Width = 200; this.dtpContractEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.numReleaseClause.Location = new System.Drawing.Point(140, y[7]); this.numReleaseClause.Width = 200; this.numReleaseClause.Maximum = 500000000;

            this.btnSave.Text = "Зберегти зміни";
            this.btnSave.Location = new System.Drawing.Point(140, 340);
            this.btnSave.Size = new System.Drawing.Size(200, 40);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.ClientSize = new System.Drawing.Size(370, 410);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7, lbl8, this.txtFullName, this.dtpDOB, this.numRating, this.cmbPosition, this.numWage, this.dtpContractStart, this.dtpContractEnd, this.numReleaseClause, this.btnSave });
            this.Name = "EditPlayerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редагувати гравця";
            this.Load += new System.EventHandler(this.EditPlayerForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.numRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReleaseClause)).EndInit();
            this.ResumeLayout(false);
        }
    }
}