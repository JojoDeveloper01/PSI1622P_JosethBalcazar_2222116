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
    public partial class Account : Form
    {
        public Account()
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
            else
            {
                MessageBox.Show("Player was not removed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool DeletePlayer(string username)
        {
            try
            {
                var sqlCheck = "SELECT COUNT(*) FROM player WHERE name != @name";
                using (var cmdCheck = new SQLiteCommand(sqlCheck, Program.conn))
                {
                    cmdCheck.Parameters.AddWithValue("@name", username);
                    int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Username does not exist", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                var sql = "DELETE FROM player WHERE name=@name";

                using (var cmd = new SQLiteCommand(sql, Program.conn))
                {
                    cmd.Parameters.AddWithValue("@name", username);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erro do SQLite: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
