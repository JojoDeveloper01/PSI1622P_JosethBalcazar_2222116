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

        private void CreateGame_Click(object sender, EventArgs e)
        {
            string columnCreate = "Game";

            string finalBossName = GetSelectedFinalBossName();
            if (string.IsNullOrEmpty(finalBossName))
            {
                return;
            }
            int finalBossId = GetIdByName("FinalBoss", finalBossName);
            if (finalBossId == -1)
            {
                MessageBox.Show("A valid Final Boss must be selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> enemyNames = GetSelectedEnemyNames();
            if (enemyNames.Count == 0)
            {
                return;
            }
            List<int> enemyIds = new List<int>();
            foreach (string name in enemyNames)
            {
                int id = GetIdByName("Enemies", name);
                if (id != -1)
                {
                    enemyIds.Add(id);
                }
            }
            if (enemyIds.Count == 0)
            {
                MessageBox.Show("At least one group of Enemies must be selected before creating a Game.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string worldName = GetSelectedWorldName();
            if (string.IsNullOrEmpty(worldName))
            {
                return;
            }
            int worldId = GetIdByName("World", worldName);
            if (worldId == -1)
            {
                MessageBox.Show("A valid World must be selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int playerId = GlobalVar.ID; // Obter o ID do jogador atualmente logado

            using (var transaction = Program.conn.BeginTransaction())
            {
                try
                {
                    if (Create(columnCreate, new Dictionary<string, string>
            {
                { "world_id", worldId.ToString() },
                { "finalBoss_id", finalBossId.ToString() }
            }, playerId)) // Passa playerId para o método Create
                    {
                        transaction.Commit();
                        MessageBox.Show($"Game created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show($"Error creating game: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CreateWorlds_Click(object sender, EventArgs e)
        {
            string columnCreate = "World";
            string name = NameWorld.Text;
            string size = SizeWorld.Text;
            string duration = DurationWorld.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(size))
            {
                MessageBox.Show("All fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(size, out _) || !int.TryParse(duration, out _))
            {
                MessageBox.Show("Size and Duration must be numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                { "duration", duration }
            }, playerId)) // Passa playerId para o método Create
                    {
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
                int finalBossId = GetIdByName("FinalBoss", name);
                if (finalBossId != -1)
                {
                    MessageBox.Show($"{columnCreate} {name} created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Error retrieving ID for {columnCreate}: FinalBoss '{name}' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

            if (Create(columnCreate, new Dictionary<string, string> { { "name", name }, { "amount", amount }, { "life", life } }, playerId)) // Passa playerId para o método Create
            {
                int enemyId = GetIdByName("Enemies", name);
                if (enemyId != -1)
                {
                    MessageBox.Show($"{columnCreate} {name} created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Error retrieving ID for {columnCreate}: Enemies '{name}' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void LoadAllData()
        {
            LoadData("World", WorldsCreated);
            LoadData("FinalBoss", FBCreated);
            LoadData("Enemies", EnemiesCreated);
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

        // Função genérica para obter ID pelo nome
        private int GetIdByName(string tableName, string name)
        {
            const string sqlTemplate = "SELECT id FROM {0} WHERE name = @name";
            string sql = string.Format(sqlTemplate, tableName);

            using (var cmd = new SQLiteCommand(sql, Program.conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }

        // Funções para obter nomes selecionados
        private List<string> GetSelectedEnemyNames()
        {
            List<string> enemyNames = new List<string>();

            foreach (DataGridViewRow row in EnemiesCreated.SelectedRows)
            {
                enemyNames.Add(row.Cells["Name"].Value.ToString());
            }

            if (enemyNames.Count == 0)
            {
                MessageBox.Show("No enemies selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return enemyNames;
        }

        private string GetSelectedWorldName()
        {
            if (WorldsCreated.SelectedRows.Count > 0)
            {
                return WorldsCreated.SelectedRows[0].Cells["Name"].Value.ToString();
            }
            else
            {
                MessageBox.Show("No world selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        private string GetSelectedFinalBossName()
        {
            if (FBCreated.SelectedRows.Count > 0)
            {
                return FBCreated.SelectedRows[0].Cells["Name"].Value.ToString();
            }
            else
            {
                MessageBox.Show("No Final Boss selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
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

        private void CreateGameEnemiesAssociation(int gameId, int enemyId)
        {
            const string sql = "INSERT INTO Game_Enemies (game_id, enemy_id) VALUES (@gameId, @enemyId)";
            using (var cmd = new SQLiteCommand(sql, Program.conn))
            {
                cmd.Parameters.AddWithValue("@gameId", gameId);
                cmd.Parameters.AddWithValue("@enemyId", enemyId);
                cmd.ExecuteNonQuery();
            }
        }

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
                LoadAllData();
                return true;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("SQLite Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void chooseWorld_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chooseFB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chooseEnemie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
