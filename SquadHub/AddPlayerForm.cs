using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace SquadHub
{
    public partial class AddPlayerForm : Form
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["SquadHubDB"].ConnectionString;

        public AddPlayerForm()
        {
            InitializeComponent();
            dtpContractEnd.Value = DateTime.Now.AddYears(1); 
            cmbPosition.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Введіть ПІБ гравця!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_AddPlayerWithContract", connection);
                    cmd.CommandType = CommandType.StoredProcedure; 

                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@OvrRating", (int)numRating.Value);
                    cmd.Parameters.AddWithValue("@PositionCode", cmbPosition.Text);
                    cmd.Parameters.AddWithValue("@WageWeekly", numWage.Value);
                    cmd.Parameters.AddWithValue("@ContractStart", dtpContractStart.Value.Date);
                    cmd.Parameters.AddWithValue("@ContractEnd", dtpContractEnd.Value.Date);
                    cmd.Parameters.AddWithValue("@ReleaseClause", numReleaseClause.Value);

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Гравця та його контракт успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}