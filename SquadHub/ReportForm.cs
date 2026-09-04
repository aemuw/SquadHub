using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace SquadHub
{
    public partial class ReportForm : Form
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["SquadHubDB"].ConnectionString;

        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    SELECT 
                        p.FullName AS [Ім'я гравця],
                        p.PositionCode AS [Позиція],
                        COUNT(s.MatchID) AS [Зіграно матчів],
                        ISNULL(SUM(s.MinutesPlayed), 0) AS [Хвилини на полі],
                        ISNULL(SUM(s.GoalsScored), 0) AS [Забиті голи],
                        ISNULL(SUM(s.YellowCards), 0) AS [Жовті картки],
                        ISNULL(SUM(s.RedCards), 0) AS [Червоні картки]
                    FROM Players p
                    LEFT JOIN Stats s ON p.PlayerID = s.PlayerID
                    GROUP BY p.PlayerID, p.FullName, p.PositionCode
                    ORDER BY [Забиті голи] DESC, [Зіграно матчів] DESC";

                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvReport.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка завантаження звіту:\n{ex.Message}");
                }
            }
        }
    }
}