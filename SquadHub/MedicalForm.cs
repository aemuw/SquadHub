using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace SquadHub
{
    public partial class MedicalForm : Form
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["SquadHubDB"].ConnectionString;

        public MedicalForm()
        {
            InitializeComponent();
        }

        private void MedicalForm_Load(object sender, EventArgs e)
        {
            LoadPlayers();
            dtpRecoveryDate.Value = DateTime.Now.AddDays(14); 
        }

        private void LoadPlayers()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT PlayerID, FullName FROM Players";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbPlayers.DataSource = dt;
                    cmbPlayers.DisplayMember = "FullName"; 
                    cmbPlayers.ValueMember = "PlayerID";  
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInjury.Text))
            {
                MessageBox.Show("Введіть діагноз!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    string query = "INSERT INTO Medical (PlayerID, InjuryType, InjuryDate, RecoveryDate) VALUES (@PlayerID, @InjuryType, @InjuryDate, @RecoveryDate)";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@PlayerID", cmbPlayers.SelectedValue);
                    cmd.Parameters.AddWithValue("@InjuryType", txtInjury.Text);
                    cmd.Parameters.AddWithValue("@InjuryDate", dtpInjuryDate.Value.Date);
                    cmd.Parameters.AddWithValue("@RecoveryDate", dtpRecoveryDate.Value.Date);

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Запис про травму успішно додано!", "Лазарет", MessageBoxButtons.OK, MessageBoxIcon.Information);
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