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
        private Form previousForm;
        public EditUsers(Form previousForm)
        {
            InitializeComponent();
            GlobalVar.LoadData("player", SeeAllUsers);
            this.previousForm = previousForm;
        }
        private void Create_Click(object sender, EventArgs e)
        {
            string username = UserCreate.Text;
            string password = PasswordCreate.Text; // Supondo que você tenha um campo para a senha também

            if (CreatePlayer(username, password))
            {
                GlobalVar.LoadData("player", SeeAllUsers);
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
        private void UpdateAllUsers_Click(object sender, EventArgs e)
        {
            GlobalVar.LoadData("player", SeeAllUsers);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string username = UsernameDel.Text;

            if (DeletePlayer(username))
            {
                GlobalVar.LoadData("player", SeeAllUsers);
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

        private void BackAdminSec_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }
    }
}
