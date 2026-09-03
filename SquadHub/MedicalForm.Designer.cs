namespace SquadHub
{
    partial class MedicalForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbPlayers;
        private System.Windows.Forms.TextBox txtInjury;
        private System.Windows.Forms.DateTimePicker dtpInjuryDate;
        private System.Windows.Forms.DateTimePicker dtpRecoveryDate;
        private System.Windows.Forms.Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbPlayers = new System.Windows.Forms.ComboBox();
            this.txtInjury = new System.Windows.Forms.TextBox();
            this.dtpInjuryDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRecoveryDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            System.Windows.Forms.Label lbl1 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lbl2 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lbl3 = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lbl4 = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // Labels
            lbl1.Text = "Гравець:"; lbl1.Location = new System.Drawing.Point(20, 20);
            lbl2.Text = "Діагноз:"; lbl2.Location = new System.Drawing.Point(20, 60);
            lbl3.Text = "Дата травми:"; lbl3.Location = new System.Drawing.Point(20, 100);
            lbl4.Text = "Дата відновлення:"; lbl4.Location = new System.Drawing.Point(20, 140); lbl4.Width = 120;

            // Controls
            this.cmbPlayers.Location = new System.Drawing.Point(140, 20); this.cmbPlayers.Width = 200; this.cmbPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtInjury.Location = new System.Drawing.Point(140, 60); this.txtInjury.Width = 200;
            this.dtpInjuryDate.Location = new System.Drawing.Point(140, 100); this.dtpInjuryDate.Width = 200; this.dtpInjuryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRecoveryDate.Location = new System.Drawing.Point(140, 140); this.dtpRecoveryDate.Width = 200; this.dtpRecoveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // Button
            this.btnSave.Text = "Відправити в лазарет";
            this.btnSave.Location = new System.Drawing.Point(140, 180);
            this.btnSave.Size = new System.Drawing.Size(200, 40);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.ClientSize = new System.Drawing.Size(370, 250);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { lbl1, lbl2, lbl3, lbl4, this.cmbPlayers, this.txtInjury, this.dtpInjuryDate, this.dtpRecoveryDate, this.btnSave });
            this.Name = "MedicalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Лазарет";
            this.Load += new System.EventHandler(this.MedicalForm_Load);

            this.ResumeLayout(false);
        }
    }
}