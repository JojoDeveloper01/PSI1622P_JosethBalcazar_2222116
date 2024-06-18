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
    public partial class EditUsers : Form
    {
        public EditUsers()
        {
            InitializeComponent();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            string username = UsernameDel.Text;

            if (DeletePlayer(username))
            {
                MessageBox.Show($"Delete Player {username} successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool DeletePlayer(string username)
        {
            try
            {
                // Verificar se o nome de usuário existe
                var sqlCheck = "SELECT COUNT(*) FROM player WHERE name = @name";
                using (var cmdCheck = new SQLiteCommand(sqlCheck, Program.conn))
                {
                    cmdCheck.Parameters.AddWithValue("@name", username);
                    int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
                    if (count == 0)
                    {
                        MessageBox.Show("Username does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                // Deletar o jogador
                var sql = "DELETE FROM player WHERE name = @name";
                using (var cmd = new SQLiteCommand(sql, Program.conn))
                {
                    cmd.Parameters.AddWithValue("@name", username);
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
        private void Create_Click(object sender, EventArgs e)
        {
            string username = UserCreate.Text;
            string password = PasswordCreate.Text; // Supondo que você tenha um campo para a senha também

            if (CreatePlayer(username, password))
            {
                MessageBox.Show($"Player {username} created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool CreatePlayer(string username, string password)
        {
            try
            {
                // Verifique se a conexão está aberta
                if (Program.conn.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("Database connection is not open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Verificar se o nome de usuário já existe
                var sqlCheck = "SELECT COUNT(*) FROM player WHERE name = @name";
                using (var cmdCheck = new SQLiteCommand(sqlCheck, Program.conn))
                {
                    cmdCheck.Parameters.AddWithValue("@name", username);
                    int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                // Inserir o novo jogador
                var sql = "INSERT INTO player (name, password) VALUES (@name, @password)";
                using (var cmd = new SQLiteCommand(sql, Program.conn))
                {
                    cmd.Parameters.AddWithValue("@name", username);
                    cmd.Parameters.AddWithValue("@password", password);
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
        private void See_All_Users_Click(object sender, EventArgs e)
        {
            try
            {
                var sql = "SELECT * FROM player";
                var cmd = new SQLiteCommand(sql);

                using (SQLiteDataReader dr = Program.ExecuteQuery(cmd))
                {
                    if (dr != null && dr.HasRows)
                    {
                        string playerInfo = "Informações dos jogadores:\n";

                        // Itera sobre todos os registros retornados
                        while (dr.Read())
                        {
                            string id_player = dr["id_player"].ToString();
                            string type = dr["type"].ToString();
                            string name = dr["name"].ToString();
                            string password = dr["password"].ToString();

                            // Concatena as informações do jogador atual na variável playerInfo
                            playerInfo += $"\nid_player: {id_player}" +
                                          $"\ntype: {type}" +
                                          $"\nname: {name}" +
                                          $"\npassword: {password}\n";
                        }
                        MessageBox.Show(playerInfo, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No players found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"SQLite Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
