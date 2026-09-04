using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace SquadHub
{
    public partial class UpdateStatsForm : Form
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["SquadHubDB"].ConnectionString;

        public UpdateStatsForm()
        {
            InitializeComponent();
        }

        private void UpdateStatsForm_Load(object sender, EventArgs e)
        {
            LoadMatches();
        }

        private void LoadMatches()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT MatchID, OpponentName + ' (' + CONVERT(varchar, MatchDate, 104) + ')' AS MatchInfo FROM Matches";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbMatches.SelectedIndexChanged -= cmbMatches_SelectedIndexChanged;

                cmbMatches.DataSource = dt;
                cmbMatches.DisplayMember = "MatchInfo";
                cmbMatches.ValueMember = "MatchID";

                cmbMatches.SelectedIndexChanged += cmbMatches_SelectedIndexChanged;
                if (cmbMatches.Items.Count > 0) LoadPlayersForMatch();
            }
        }

        private void cmbMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPlayersForMatch();
        }

        private void LoadPlayersForMatch()
        {
            if (cmbMatches.SelectedValue == null) 
                return;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    SELECT p.PlayerID, p.FullName 
                    FROM Stats s
                    JOIN Players p ON s.PlayerID = p.PlayerID
                    WHERE s.MatchID = @MatchID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MatchID", cmbMatches.SelectedValue);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbPlayers.DataSource = dt;
                cmbPlayers.DisplayMember = "FullName";
                cmbPlayers.ValueMember = "PlayerID";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbMatches.SelectedValue == null || cmbPlayers.SelectedValue == null)
            {
                MessageBox.Show("Виберіть матч та гравця!"); return;
            }

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                // Оновлюємо конкретний запис у таблиці Stats
                string query = @"
                    UPDATE Stats 
                    SET MinutesPlayed = @Min, GoalsScored = @Goals, YellowCards = @Y, RedCards = @R 
                    WHERE MatchID = @MatchID AND PlayerID = @PlayerID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Min", (int)numMinutes.Value);
                cmd.Parameters.AddWithValue("@Goals", (int)numGoals.Value);
                cmd.Parameters.AddWithValue("@Y", (int)numYellow.Value);
                cmd.Parameters.AddWithValue("@R", (int)numRed.Value);
                cmd.Parameters.AddWithValue("@MatchID", cmbMatches.SelectedValue);
                cmd.Parameters.AddWithValue("@PlayerID", cmbPlayers.SelectedValue);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Статистику гравця в матчі збережено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    numMinutes.Value = 0; numGoals.Value = 0; numYellow.Value = 0; numRed.Value = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка збереження: " + ex.Message);
                }
            }
        }
    }
}