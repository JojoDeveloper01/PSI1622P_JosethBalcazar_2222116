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
    public partial class Sign_in : Form
    {
        public Sign_in()
        {
            InitializeComponent();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            string username = usernameLogin.Text;
            string password = passwordLogin.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (VerifyUser(username, password))
            {
                MessageBox.Show("Sign in successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Username or Password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerifyUser(string username, string password)
        {
            var sql = "SELECT id_player, type FROM player WHERE name = @username AND password = @password";
            var cmd = new SQLiteCommand(sql);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            using (SQLiteDataReader dr = Program.ExecuteQuery(cmd))
            {
                if (dr != null && dr.Read())
                {
                    GlobalVar.ID = Convert.ToInt32(dr["id_player"]);
                    GlobalVar.Type = dr["type"].ToString();
                    GlobalVar.Username = username;
                    GlobalVar.Password = password;
                    this.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
