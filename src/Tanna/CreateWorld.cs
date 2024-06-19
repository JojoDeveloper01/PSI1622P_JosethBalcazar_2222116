using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

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

            // Verificar se o boss final foi criado
            var finalBossId = GetFinalBossId();
            if (finalBossId == -1)
            {
                MessageBox.Show("FinalBoss must be created before creating a World.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar se pelo menos um grupo de inimigos foi criado
            var enemiesIds = GetEnemiesIds();
            if (enemiesIds.Count == 0)
            {
                MessageBox.Show("At least one group of Enemies must be created before creating a World.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Criar o mundo e associar os IDs do boss final e dos inimigos
            if (Create(columnCreate, new Dictionary<string, string>
    {
        { "name", name },
        { "size", size },
        { "duration", duration },
        { "id_Enemies", string.Join(",", enemiesIds) },
        { "id_FinalBoss", finalBossId.ToString() }
    }))
            {
                MessageBox.Show($"{columnCreate} {name} created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int GetFinalBossId()
        {
            const string sql = "SELECT id FROM FinalBoss LIMIT 1";
            using (var cmd = new SQLiteCommand(sql, Program.conn))
            {
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }

        private List<int> GetEnemiesIds()
        {
            const string sql = "SELECT id FROM Enemies";
            var ids = new List<int>();
            using (var cmd = new SQLiteCommand(sql, Program.conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    ids.Add(reader.GetInt32(0));
                }
            }
            return ids;
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

            if (Create(columnCreate, new Dictionary<string, string>
    {
        { "name", name },
        { "life", life },
        { "stamina", stamina },
        { "velocity", velocity },
        { "energy", energy }
    }))
            {
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

            if (Create(columnCreate, new Dictionary<string, string>
    {
        { "name", name },
        { "amount", amount },
        { "life", life }
    }))
            {
                MessageBox.Show($"{columnCreate} {name} created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private bool Create(string columnCreate, Dictionary<string, string> parameters)
        {
            try
            {
                // Verifique se a conexão está aberta
                if (Program.conn.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("Database connection is not open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Verificar se o nome já existe
                var sqlCheck = $"SELECT COUNT(*) FROM {columnCreate} WHERE name = @name";
                using (var cmdCheck = new SQLiteCommand(sqlCheck, Program.conn))
                {
                    cmdCheck.Parameters.AddWithValue("@name", parameters["name"]);
                    int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show($"Name of {columnCreate} already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                // Construir dinamicamente a consulta SQL para inserção
                var columns = string.Join(", ", parameters.Keys);
                var values = string.Join(", ", parameters.Keys.Select(k => "@" + k));
                var sql = $"INSERT INTO {columnCreate} ({columns}) VALUES ({values})";

                using (var cmd = new SQLiteCommand(sql, Program.conn))
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue("@" + param.Key, param.Value);
                    }
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("SQLite Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
