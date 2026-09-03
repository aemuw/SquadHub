using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace SquadHub
{
    public partial class MatchForm : Form
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["SquadHubDB"].ConnectionString;
        private int _currentMatchId = 0;

        public MatchForm()
        {
            InitializeComponent();
        }

        private void MatchForm_Load(object sender, EventArgs e)
        {
            LoadTactics();
            LoadPlayers();
        }

        private void LoadTactics()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT TacticID, FormationName FROM Tactics", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cmbTactics.DataSource = dt;
                cmbTactics.DisplayMember = "FormationName";
                cmbTactics.ValueMember = "TacticID";
            }
        }

        private void LoadPlayers()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT PlayerID, FullName FROM Players", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cmbPlayers.DataSource = dt;
                cmbPlayers.DisplayMember = "FullName";
                cmbPlayers.ValueMember = "PlayerID";
            }
        }

        private void btnCreateMatch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOpponent.Text))
            {
                MessageBox.Show("Введіть назву суперника!"); return;
            }

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO Matches (OpponentName, MatchDate, TacticID) 
                                     VALUES (@Opponent, @Date, @TacticID);
                                     SELECT SCOPE_IDENTITY();";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Opponent", txtOpponent.Text);
                    cmd.Parameters.AddWithValue("@Date", dtpMatchDate.Value.Date);
                    cmd.Parameters.AddWithValue("@TacticID", cmbTactics.SelectedValue);

                    _currentMatchId = Convert.ToInt32(cmd.ExecuteScalar());

                    MessageBox.Show("Матч успішно створено! Тепер виберіть стартовий склад.");

                    btnCreateMatch.Enabled = false;
                    gbSquad.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка: {ex.Message}");
                }
            }
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Stats (MatchID, PlayerID) VALUES (@MatchID, @PlayerID)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MatchID", _currentMatchId);
                    cmd.Parameters.AddWithValue("@PlayerID", cmbPlayers.SelectedValue);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Гравця додано до заявки на матч!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Медичне обмеження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}