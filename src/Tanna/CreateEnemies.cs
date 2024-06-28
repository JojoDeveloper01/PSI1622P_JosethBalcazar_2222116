using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanna
{
    public partial class CreateEnemies : Form
    {
        private Form previousForm;
        public CreateEnemies(Form previousForm)
        {
            InitializeComponent();
            GlobalVar.LoadData("Enemies", EnemiesCreated);
            this.previousForm = previousForm;
        }

        private void CreateGroupEnemies_Click(object sender, EventArgs e)
        {
            string columnCreate = "Enemies";
            string name = NameEnemies.Text;
            string amount = AmountEnemies.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(amount))
            {
                MessageBox.Show("All fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(amount, out int amountValue))
            {
                MessageBox.Show("Amount must be numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (amountValue > 500)
            {
                MessageBox.Show("Amount must not exceed 500.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (GlobalVar.IsNameAlreadyExists("Enemies", name))
            {
                MessageBox.Show($"An Enemies group with the name '{name}' already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int playerId = GlobalVar.ID; // Obter o ID do jogador atualmente logado

            if (GlobalVar.Create(columnCreate, new Dictionary<string, string> { { "name", name }, { "amount", amount } }, playerId)) // Passa playerId para o método Create
            {
                int enemyId = GlobalVar.GetIdByName("Enemies", name);
                if (enemyId != -1)
                {
                    GlobalVar.LoadData("Enemies", EnemiesCreated);
                    MessageBox.Show($"{columnCreate} {name} created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Error retrieving ID for {columnCreate}: Enemies '{name}' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (EnemiesCreated.CurrentRow == null)
            {
                MessageBox.Show("No row selected for update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow row = EnemiesCreated.CurrentRow;

            // Obtain the ID of the selected row
            if (!int.TryParse(row.Cells["id"].Value?.ToString(), out int itemId))
            {
                MessageBox.Show("Invalid item ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = row.Cells["name"].Value?.ToString();
            string amount = row.Cells["amount"].Value?.ToString();

            // Debug output to display row information
            //MessageBox.Show($"Processing row: ID={itemId}, Name={name}, Amount={amount}");

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(amount))
            {
                MessageBox.Show("All fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(amount, out int amountValue))
            {
                MessageBox.Show("Amount must be numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (amountValue > 500)
            {
                MessageBox.Show("Amount must not exceed 500.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int playerId = GlobalVar.ID; // Obter o ID do jogador atualmente logado

            using (var transaction = Program.conn.BeginTransaction())
            {
                try
                {
                    // Build the dictionary of columns
                    var columns = new Dictionary<string, string>
            {
                { "name", name },
                { "amount", amount }
            };

                    // Update Enemies group using global function and the item ID
                    bool updateResult = GlobalVar.Update("Enemies", itemId, columns, playerId);
                    if (updateResult)
                    {
                        transaction.Commit();
                        MessageBox.Show($"Enemies group {name} updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Failed to update Enemies group {name}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error updating Enemies group: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void GetSelectedEnemyNames()
        {
            GlobalVar.SelectedEnemiesName.Clear();
            foreach (DataGridViewRow row in EnemiesCreated.SelectedRows)
            {
                GlobalVar.SelectedEnemiesName.Add(row.Cells["Name"].Value.ToString());
            }

            GlobalVar.UpdateSelectedEnemiesIds();
        }

        private void DelEnemies_Click(object sender, EventArgs e)
        {
            string name = NameDelEnemies.Text;
            string columnName = "Enemies";

            if (GlobalVar.Delete(name, columnName))
            {
                GlobalVar.LoadData("Enemies", EnemiesCreated);
                MessageBox.Show($"Delete {columnName} {name} successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BackEnemies_Click(object sender, EventArgs e)
        {
            GetSelectedEnemyNames();
            this.previousForm.Show();
            this.Close();
        }
    }
}
