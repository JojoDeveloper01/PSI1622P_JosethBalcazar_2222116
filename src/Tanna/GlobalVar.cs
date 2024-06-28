    using System.Data.SQLite;
using System.Data;
using System.Data.SqlClient;

namespace Tanna
{
    public static class GlobalVar
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static int ID { get; set; }
        public static int Type { get; set; }
        public static string SelectedGameName { get; set; }
        public static string SelectedWorldName { get; set; }
        public static string SelectedFBName { get; set; }
        public static List<string> SelectedEnemiesName { get; set; } = new List<string>();

        public static List<int> SelectedEnemiesIds = new List<int>();
       
        public static void Logout(Home homeForm)
        {
            // Redefinir as variáveis globais para o estado de deslogado
            Username = "";
            Password = "";
            ID = 0;
            Type = 0;
        }
        
        public static void LoadData(string tableName, DataGridView dataGridView)
        {
            string sql;

            switch (tableName)
            {
                case "Game":
                    sql = $@"
                SELECT 
                    g.name,
                    w.name as World,
                    f.name as 'FinalBoss',
                    (
                        SELECT GROUP_CONCAT(e.name, ', ')
                        FROM Game_Enemies ge
                        JOIN Enemies e ON ge.enemy_id = e.id
                        WHERE ge.game_id = g.id
                    ) as Enemies
                FROM 
                    Game g
                JOIN 
                    World w ON g.world_id = w.id
                JOIN 
                    FinalBoss f ON g.finalBoss_id = f.id
                WHERE 
                    g.player_id = {ID}";
                    break;
                case "AllGames":
                    sql = @"
                SELECT 
                    g.name,
                    w.name as World,
                    f.name as 'FinalBoss',
                    (
                        SELECT GROUP_CONCAT(e.name, ', ')
                        FROM Game_Enemies ge
                        JOIN Enemies e ON ge.enemy_id = e.id
                        WHERE ge.game_id = g.id
                    ) as Enemies
                FROM 
                    Game g
                JOIN 
                    World w ON g.world_id = w.id
                JOIN 
                    FinalBoss f ON g.finalBoss_id = f.id;";
                    break;
                case "World":
                    sql = $"SELECT id, name, size, duration FROM World WHERE player_id = {ID}";
                    break;
                case "FinalBoss":
                    sql = $"SELECT id, name, life, velocity, damage FROM FinalBoss WHERE player_id = {ID}";
                    break;
                case "Enemies":
                    sql = $"SELECT id, name, amount FROM Enemies WHERE player_id = {ID}";
                    break;
                case "player":
                    sql = "SELECT * FROM player";
                    break;
                case "SelectedGames":
                    ShowGames(dataGridView);
                    return; // Retorna para evitar execução do restante do código
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

                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao carregar os dados da tabela {tableName}: " + ex.Message);
            }
        }

        public static void ShowGames(DataGridView dataGridView)
        {
            // Limpa o DataGridView antes de adicionar novos itens
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            // Adiciona as colunas ao DataGridView
            dataGridView.Columns.Add("World", "World");
            dataGridView.Columns.Add("FinalBoss", "Final Boss");
            dataGridView.Columns.Add("Enemies", "Enemies");

            // Concatena os nomes dos inimigos selecionados
            string selectedEnemies = string.Join(", ", SelectedEnemiesName);

            // Adiciona uma linha com os dados selecionados
            dataGridView.Rows.Add(SelectedWorldName, SelectedFBName, selectedEnemies);

            // Ajusta a largura das colunas para caber no conteúdo
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        public static bool Create(string tableName, Dictionary<string, string> columns, int playerId)
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
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating {tableName}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool Update(string tableName, int itemId, Dictionary<string, string> columns, int playerId)
        {
            string sqlCommand = ""; // Variável para armazenar o comando SQL

            try
            {
                using (var cmd = Program.conn.CreateCommand())
                {
                    cmd.CommandText = $"UPDATE {tableName} SET ";

                    // Add columns to update
                    foreach (var column in columns)
                    {
                        cmd.CommandText += $"{column.Key} = @{column.Key}, ";
                        cmd.Parameters.AddWithValue($"@{column.Key}", column.Value);
                    }

                    // Remove the last comma and space
                    cmd.CommandText = cmd.CommandText.TrimEnd(',', ' ');

                    if(tableName == "player")
                    {
                        cmd.CommandText += " WHERE id_player = @itemId";
                    }
                    else
                    {
                        cmd.CommandText += " WHERE id = @itemId AND player_id = @playerId";
                    }
                    cmd.Parameters.AddWithValue("@itemId", itemId);
                    cmd.Parameters.AddWithValue("@playerId", playerId);

                    // Assign the SQL command to the variable
                    sqlCommand = cmd.CommandText;

                    // Execute the update
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Check if any rows were affected
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        // If no rows were affected, throw an exception
                        throw new Exception($"No rows updated for item ID {itemId} and player ID {playerId}.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception message and SQL command
                string errorMessage = $"Error in Update {tableName}: {ex.Message}\nSQL Command: {sqlCommand}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public static void UpdateSelectedEnemiesIds()
        {
            SelectedEnemiesIds.Clear();

            foreach (var enemyName in SelectedEnemiesName)
            {
                int enemyId = GetIdByName("Enemies", enemyName);
                if (enemyId != -1)
                {
                    SelectedEnemiesIds.Add(enemyId);
                }
            }
        }

        public static int GetIdByName(string tableName, string name)
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

        public static bool Delete(string name, string column)
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

        public static bool IsNameAlreadyExists(string tableName, string name)
        {
            const string sqlTemplate = "SELECT COUNT(*) FROM {0} WHERE name = @name";
            string sql = string.Format(sqlTemplate, tableName);

            using (var cmd = new SQLiteCommand(sql, Program.conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public static int GetLastInsertId(string tableName)
        {
            const string sqlTemplate = "SELECT seq FROM sqlite_sequence WHERE name = @tableName";
            using (var cmd = new SQLiteCommand(sqlTemplate, Program.conn))
            {
                cmd.Parameters.AddWithValue("@tableName", tableName);
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }
    }
}
