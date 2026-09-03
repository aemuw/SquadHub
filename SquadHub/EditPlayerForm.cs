using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace SquadHub
{
    public partial class EditPlayerForm : Form
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["SquadHubDB"].ConnectionString;
        private int _playerId;

        public EditPlayerForm(int playerId)
        {
            InitializeComponent();
            _playerId = playerId;
        }

        private void EditPlayerForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    SELECT p.FullName, p.DOB, p.OvrRating, p.PositionCode, 
                           c.WageWeekly, c.ContractStart, c.ContractEnd, c.ReleaseClause
                    FROM Players p
                    LEFT JOIN Contracts c ON p.PlayerID = c.PlayerID
                    WHERE p.PlayerID = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", _playerId);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtFullName.Text = reader["FullName"].ToString();
                        dtpDOB.Value = Convert.ToDateTime(reader["DOB"]);
                        numRating.Value = Convert.ToInt32(reader["OvrRating"]);
                        cmbPosition.Text = reader["PositionCode"].ToString();

                        if (reader["WageWeekly"] != DBNull.Value) 
                            numWage.Value = Convert.ToDecimal(reader["WageWeekly"]);
                        if (reader["ContractStart"] != DBNull.Value) 
                            dtpContractStart.Value = Convert.ToDateTime(reader["ContractStart"]);
                        if (reader["ContractEnd"] != DBNull.Value) 
                            dtpContractEnd.Value = Convert.ToDateTime(reader["ContractEnd"]);
                        if (reader["ReleaseClause"] != DBNull.Value) 
                            numReleaseClause.Value = Convert.ToDecimal(reader["ReleaseClause"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка завантаження даних: " + ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Введіть ПІБ гравця!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_UpdatePlayerWithContract", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PlayerID", _playerId);
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value.Date);
                cmd.Parameters.AddWithValue("@OvrRating", (int)numRating.Value);
                cmd.Parameters.AddWithValue("@PositionCode", cmbPosition.Text);
                cmd.Parameters.AddWithValue("@WageWeekly", numWage.Value);
                cmd.Parameters.AddWithValue("@ContractStart", dtpContractStart.Value.Date);
                cmd.Parameters.AddWithValue("@ContractEnd", dtpContractEnd.Value.Date);
                cmd.Parameters.AddWithValue("@ReleaseClause", numReleaseClause.Value);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Дані успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка оновлення: " + ex.Message);
                }
            }
        }
    }
}