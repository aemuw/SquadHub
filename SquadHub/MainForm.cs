using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace SquadHub
{
    public partial class MainForm : Form
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["SquadHubDB"].ConnectionString;

        public MainForm()
        {
            InitializeComponent();
            SetupContextMenu();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadPlayersData();
        }

        private void btnLoadPlayers_Click(object sender, EventArgs e)
        {
            LoadPlayersData();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            using (AddPlayerForm addForm = new AddPlayerForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                    LoadPlayersData();
            }
        }

        private void EditPlayer_Click(object sender, EventArgs e)
        {
            if (dgvPlayers.CurrentRow == null)
                return;

            int playerId = Convert.ToInt32(dgvPlayers.CurrentRow.Cells["ID"].Value);

            using (EditPlayerForm editForm = new EditPlayerForm(playerId))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                    LoadPlayersData();
            }
        }

        private void DeletePlayer_Click(object sender, EventArgs e)
        {
            if (dgvPlayers.CurrentRow == null)
                return;

            int playerId = Convert.ToInt32(dgvPlayers.CurrentRow.Cells["ID"].Value);
            string playerName = dgvPlayers.CurrentRow.Cells["Ім'я гравця"].Value.ToString();

            var confirmResult = MessageBox.Show($"Ви дійсно хочете видалити гравця {playerName}?\nУсі його контракти та статистика також будуть видалені.",
                                                 "Підтвердження видалення",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    try
                    {
                        string query = "DELETE FROM Players WHERE PlayerID = @PlayerID";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@PlayerID", playerId);

                        connection.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Гравця успішно видалено.");
                        LoadPlayersData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка при видаленні: {ex.Message}");
                    }
                }
            }
        }

        private void SetupContextMenu()
        {
            ContextMenuStrip gridMenu = new ContextMenuStrip();

            ToolStripMenuItem editItem = new ToolStripMenuItem("Редагувати гравця");
            ToolStripMenuItem deleteItem = new ToolStripMenuItem("Видалити гравця");

            deleteItem.Click += DeletePlayer_Click;
            editItem.Click += EditPlayer_Click;

            gridMenu.Items.Add(editItem);
            gridMenu.Items.Add(deleteItem);

            dgvPlayers.ContextMenuStrip = gridMenu;
        }

        private void LoadPlayersData()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            PlayerID AS [ID], 
                            FullName AS [Ім'я гравця], 
                            PositionCode AS [Позиція], 
                            OvrRating AS [Рейтинг], 
                            DOB AS [Дата народження]
                        FROM Players";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvPlayers.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка підключення до БД:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMedical_Click(object sender, EventArgs e)
        {
            using (MedicalForm medForm = new MedicalForm())
            {
                medForm.ShowDialog();
            }
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            using (MatchForm matchForm = new MatchForm())
            {
                matchForm.ShowDialog();
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            using (ReportForm reportForm = new ReportForm())
            {
                reportForm.ShowDialog();
            }
        }

        private void btnUpdateStats_Click(object sender, EventArgs e)
        {
            using (UpdateStatsForm statsForm = new UpdateStatsForm())
            {
                statsForm.ShowDialog();
            }
        }
    }
}