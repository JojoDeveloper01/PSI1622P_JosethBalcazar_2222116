using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanna
{
    public partial class CreateWorld : Form
    {
        public CreateWorld()
        {
            InitializeComponent();
            LoadAllData();
        }

        private int _recentFinalBossId = -1;
        private List<int> _recentEnemiesIds = new List<int>();

        private void CreateWorlds_Click(object sender, EventArgs e)
        {
            string columnCreate = "World";
            string name = NameWorld.Text;
            string size = SizeWorld.Text;
            string duration = DurationWorld.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(size) || string.IsNullOrWhiteSpace(duration))
            {
                MessageBox.Show("All fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(size, out _) || !int.TryParse(duration, out _))
            {
                MessageBox.Show("Size and Duration must be numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_recentFinalBossId == -1)
            {
                MessageBox.Show("FinalBoss must be created before creating a World.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_recentEnemiesIds.Count == 0)
            {
                MessageBox.Show("At least one group of Enemies must be created before creating a World.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int playerId = GlobalVar.ID; // Obter o ID do jogador atualmente logado

            using (var transaction = Program.conn.BeginTransaction())
            {
                try
                {
                    if (Create(columnCreate, new Dictionary<string, string>
            {
                { "name", name },
                { "size", size },
                { "duration", duration },
                { "id_FinalBoss", _recentFinalBossId.ToString() }
            }, playerId)) // Passa playerId para o método Create
                    {
                        int worldId = GetLastInsertId(columnCreate);

                        foreach (var enemyId in _recentEnemiesIds)
                        {
                            CreateWorldEnemiesAssociation(worldId, enemyId);
                        }

                        transaction.Commit();
                        MessageBox.Show($"{columnCreate} {name} created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllData();
                    }
                    else
                    {
                        transaction.Rollback();
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error creating {columnCreate}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void CreateFB_Click(object sender, EventArgs e)
        {
            string columnCreate = "FinalBoss";
            string name = NameFB.Text;
            string life = LifeFB.Text;
            string stamina = StaminaFB.Text;
            string velocity = VelocityFB.Text;
            string energy = EnergyFB.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(life) ||
                string.IsNullOrWhiteSpace(stamina) || string.IsNullOrWhiteSpace(velocity) || string.IsNullOrWhiteSpace(energy))
            {
                MessageBox.Show("All fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(life, out _) || !int.TryParse(stamina, out _) ||
                !int.TryParse(velocity, out _) || !int.TryParse(energy, out _))
            {
                MessageBox.Show("Life, Stamina, Velocity, and Energy must be numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int playerId = GlobalVar.ID; // Obter o ID do jogador atualmente logado

            if (Create(columnCreate, new Dictionary<string, string>
    {
        { "name", name },
        { "life", life },
        { "stamina", stamina },
        { "velocity", velocity },
        { "energy", energy }
    }, playerId)) // Passa playerId para o método Create
            {
                _recentFinalBossId = GetLastInsertId(columnCreate);
                MessageBox.Show($"{columnCreate} {name} created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void CreateGroupEnemies_Click(object sender, EventArgs e)
        {
            string columnCreate = "Enemies";
            string name = NameEnemies.Text;
            string amount = AmountEnemies.Text;
            string life = LifeEnemies.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(amount) || string.IsNullOrWhiteSpace(life))
            {
                MessageBox.Show("All fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(amount, out _) || !int.TryParse(life, out _))
            {
                MessageBox.Show("Amount and Life must be numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int playerId = GlobalVar.ID; // Obter o ID do jogador atualmente logado

            if (Create(columnCreate, new Dictionary<string, string>
    {
        { "name", name },
        { "amount", amount },
        { "life", life }
    }, playerId)) // Passa playerId para o método Create
            {
                _recentEnemiesIds.Add(GetLastInsertId(columnCreate));
                MessageBox.Show($"{columnCreate} {name} created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CreateWorldEnemiesAssociation(int worldId, int enemyId)
        {
            const string sql = "INSERT INTO World_Enemies (world_id, enemy_id) VALUES (@worldId, @enemyId)";
            using (var cmd = new SQLiteCommand(sql, Program.conn))
            {
                cmd.Parameters.AddWithValue("@worldId", worldId);
                cmd.Parameters.AddWithValue("@enemyId", enemyId);
                cmd.ExecuteNonQuery();
            }
        }

        private int GetLastInsertId(string tableName)
        {
            const string sqlTemplate = "SELECT seq FROM sqlite_sequence WHERE name = @tableName";
            using (var cmd = new SQLiteCommand(sqlTemplate, Program.conn))
            {
                cmd.Parameters.AddWithValue("@tableName", tableName);
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }

        private bool Create(string tableName, Dictionary<string, string> columns, int playerId)
        {
            try
            {
                // Adiciona o campo player_id ao dicionário de colunas
                columns.Add("player_id", playerId.ToString());

                var columnNames = string.Join(", ", columns.Keys);
                var columnValues = string.Join(", ", columns.Values.Select(v => $"'{v}'"));
                string query = $"INSERT INTO {tableName} ({columnNames}) VALUES ({columnValues})";

                using (var cmd = new SQLiteCommand(query, Program.conn))
                {
                    cmd.ExecuteNonQuery();
                    LoadAllData(); // Considerando que LoadAllData() carrega novamente os dados atualizados
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating {tableName}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }





        private void LoadData(string tableName, DataGridView dataGridView)
        {
            string sql;

            switch (tableName)
            {
                case "World":
                    sql = $"SELECT name, size, duration FROM World WHERE player_id = {GlobalVar.ID}";
                    break;
                case "FinalBoss":
                    sql = $"SELECT name, life, stamina, velocity, energy FROM FinalBoss WHERE player_id = {GlobalVar.ID}";
                    break;
                case "Enemies":
                    sql = $"SELECT name, amount, life FROM Enemies WHERE player_id = {GlobalVar.ID}";
                    break;
                default:
                    MessageBox.Show("Invalid table name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            try
            {
                using (var cmd = new SQLiteCommand(sql, Program.conn))
                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao carregar os dados da tabela {tableName}: " + ex.Message);
            }
        }

        private void LoadAllData()
        {
            LoadData("World", WorldsCreated);
            LoadData("FinalBoss", FBCreated);
            LoadData("Enemies", EnemiesCreated);
        }

        private void DelWorld_Click(object sender, EventArgs e)
        {
            string name = NameDelWorld.Text;
            string columnName = "World";

            if (Delete(name, columnName))
            {
                MessageBox.Show($"Delete {columnName} {name} successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DelFB_Click(object sender, EventArgs e)
        {
            string name = NameDelFB.Text;
            string columnName = "FinalBoss";

            if (Delete(name, columnName))
            {
                MessageBox.Show($"Delete {columnName} {name} successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DelEnemies_Click(object sender, EventArgs e)
        {
            string name = NameDelEnemies.Text;
            string columnName = "Enemies";

            if (Delete(name, columnName))
            {
                MessageBox.Show($"Delete {columnName} {name} successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /*-------------------------------------------------------------*/



        private bool Delete(string name, string column)
        {
            try
            {
                // Verificar se o nome de usuário existe
                var sqlCheck = $"SELECT COUNT(*) FROM {column} WHERE name = @name";
                using (var cmdCheck = new SQLiteCommand(sqlCheck, Program.conn))
                {
                    cmdCheck.Parameters.AddWithValue("@name", name);
                    int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
                    if (count == 0)
                    {
                        MessageBox.Show("Username does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                // Deletar o jogador
                var sql = $"DELETE FROM {column} WHERE name = @name";
                using (var cmd = new SQLiteCommand(sql, Program.conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("SQLite Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
