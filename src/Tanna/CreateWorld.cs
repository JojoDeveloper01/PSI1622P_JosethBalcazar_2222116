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
        private Form previousForm;
        public CreateWorld(Form previousForm)
        {
            InitializeComponent();
            GlobalVar.LoadData("World", WorldsCreated);
            this.previousForm = previousForm;
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

            if (!int.TryParse(size, out _))
            {
                MessageBox.Show("Size must be numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int playerId = GlobalVar.ID; // Obter o ID do jogador atualmente logado

            // Verificar se o nome já existe na tabela World
            if (GlobalVar.IsNameAlreadyExists("World", name))
            {
                MessageBox.Show($"A World with the name '{name}' already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var transaction = Program.conn.BeginTransaction())
            {
                try
                {
                    // Construir o dicionário de colunas
                    var columns = new Dictionary<string, string>
            {
                { "name", name },
                { "size", size }
            };

                    // Adicionar a duração se não estiver vazia
                    if (!string.IsNullOrWhiteSpace(duration))
                    {
                        columns.Add("duration", duration);
                    }

                    if (GlobalVar.Create(columnCreate, columns, playerId)) // Passa playerId para o método Create
                    {
                        transaction.Commit();
                        GlobalVar.LoadData("World", WorldsCreated);
                        MessageBox.Show($"{columnCreate} {name} created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void GetSelectedWorldName()
        {
            if (WorldsCreated.SelectedRows.Count > 0)
            {
                GlobalVar.SelectedWorldName = WorldsCreated.SelectedRows[0].Cells["Name"].Value.ToString();
            }
            else
            {
                GlobalVar.SelectedWorldName = string.Empty;
            }
        }

        private void DelWorld_Click(object sender, EventArgs e)
        {
            string name = NameDelWorld.Text;
            string columnName = "World";

            if (GlobalVar.Delete(name, columnName))
            {
                GlobalVar.LoadData("World", WorldsCreated);
                MessageBox.Show($"Delete {columnName} {name} successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BackWorld_Click(object sender, EventArgs e)
        {
            GetSelectedWorldName();
            this.previousForm.Show();
            this.Close();
        }
    }
}
