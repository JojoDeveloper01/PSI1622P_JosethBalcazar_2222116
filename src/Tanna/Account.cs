using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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

            EditUsers.Visible = false;

            if (GlobalVar.Type == 1)
            {
                EditUsers.Visible = true;
            }
        }

        private void Account_Load(object sender, EventArgs e)
        {
            ID.Text = GlobalVar.ID.ToString();
            Username.Text = GlobalVar.Username;
            Password.Text = GlobalVar.Password;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            string query = "UPDATE player SET name = @name, Password = @password WHERE id_player = @id";
            using (SQLiteCommand cmd = new SQLiteCommand(query, Program.conn))
            {
                cmd.Parameters.AddWithValue("@id", GlobalVar.ID);
                cmd.Parameters.AddWithValue("@name", Username.Text);
                cmd.Parameters.AddWithValue("@password", Password.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Atualizar variáveis globais
                    GlobalVar.Username = Username.Text;
                    GlobalVar.Password = Password.Text;
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

        private void EditUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditUsers editUsers = new();
            editUsers.ShowDialog();
            this.Show();
        }

        private void CreateWorld_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateWorld createWorld = new();
            createWorld.ShowDialog();
            this.Show();
        }
    }
}
