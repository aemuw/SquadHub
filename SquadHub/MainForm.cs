using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace SquadHubApp
{
    public partial class MainForm : Form
    {
        // Зчитуємо рядок підключення з App.config
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["SquadHubDB"].ConnectionString;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Автоматично підтягуємо гравців при запуску форми
            LoadPlayersData();
        }

        private void btnLoadPlayers_Click(object sender, EventArgs e)
        {
            LoadPlayersData();
        }

        private void LoadPlayersData()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    // Запит з нормальними назвами колонок для таблиці
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
    }
}