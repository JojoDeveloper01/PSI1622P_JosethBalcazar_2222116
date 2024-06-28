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
    public partial class CreateFinalBoss : Form
    {
        private Form previousForm;
        public CreateFinalBoss(Form previousForm)
        {
            InitializeComponent();
            GlobalVar.LoadData("FinalBoss", FBCreated);
            this.previousForm = previousForm;
        }

        private void CreateFB_Click(object sender, EventArgs e)
        {
            string columnCreate = "FinalBoss";
            string name = NameFB.Text;
            string life = LifeFB.Text;
            string velocity = VelocityFB.Text;
            string damage = DamageFB.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(life) || string.IsNullOrWhiteSpace(velocity) || string.IsNullOrWhiteSpace(damage))
            {
                MessageBox.Show("All fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(life, out int lifeValue) || !int.TryParse(velocity, out int velocityValue) || !int.TryParse(damage, out int damageValue))
            {
                MessageBox.Show("Life, Velocity, and Damage must be numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (velocityValue > 15)
            {
                MessageBox.Show("Velocity must not exceed 50.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (damageValue > 50)
            {
                MessageBox.Show("Damage must not exceed 50.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (GlobalVar.IsNameAlreadyExists("FinalBoss", name))
            {
                MessageBox.Show($"A FinalBoss with the name '{name}' already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int playerId = GlobalVar.ID; // Obter o ID do jogador atualmente logado

            if (GlobalVar.Create(columnCreate, new Dictionary<string, string>
    {
     { "name", name },
     { "life", lifeValue.ToString() },
     { "velocity", velocityValue.ToString() },
     { "damage", damageValue.ToString() } }, playerId)) // Passa playerId para o método Create
            {
                int finalBossId = GlobalVar.GetIdByName("FinalBoss", name);
                if (finalBossId != -1)
                {
                    GlobalVar.LoadData("FinalBoss", FBCreated);
                    MessageBox.Show($"{columnCreate} {name} created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Error retrieving ID for {columnCreate}: FinalBoss '{name}' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (FBCreated.CurrentRow == null)
            {
                MessageBox.Show("No row selected for update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow row = FBCreated.CurrentRow;

            // Obtain the ID of the selected row
            if (!int.TryParse(row.Cells["id"].Value?.ToString(), out int itemId))
            {
                MessageBox.Show("Invalid item ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = row.Cells["name"].Value?.ToString();
            string life = row.Cells["life"].Value?.ToString();
            string velocity = row.Cells["velocity"].Value?.ToString();
            string damage = row.Cells["damage"].Value?.ToString();

            // Debug output to display row information
            //MessageBox.Show($"Processing row: ID={itemId}, Name={name}, Life={life}, Velocity={velocity}, Damage={damage}");

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(life) || string.IsNullOrWhiteSpace(velocity) || string.IsNullOrWhiteSpace(damage))
            {
                MessageBox.Show("All fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(life, out int lifeValue) || !int.TryParse(velocity, out int velocityValue) || !int.TryParse(damage, out int damageValue))
            {
                MessageBox.Show("Life, Velocity, and Damage must be numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (velocityValue > 15)
            {
                MessageBox.Show("Velocity must not exceed 15.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (damageValue > 50)
            {
                MessageBox.Show("Damage must not exceed 50.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                { "life", lifeValue.ToString() },
                { "velocity", velocityValue.ToString() },
                { "damage", damageValue.ToString() }
            };

                    // Update FinalBoss using global function and the item ID
                    bool updateResult = GlobalVar.Update("FinalBoss", itemId, columns, playerId);
                    if (updateResult)
                    {
                        transaction.Commit();
                        MessageBox.Show($"FinalBoss {name} updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Failed to update FinalBoss {name}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error updating FinalBoss: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GetSelectedFinalBossName()
        {
            if (FBCreated.SelectedRows.Count > 0)
            {
                GlobalVar.SelectedFBName = FBCreated.SelectedRows[0].Cells["Name"].Value.ToString();
            }
            else
            {
                GlobalVar.SelectedFBName = string.Empty;
            }
        }

        private void DelFB_Click(object sender, EventArgs e)
        {
            string name = NameDelFB.Text;
            string columnName = "FinalBoss";

            if (GlobalVar.Delete(name, columnName))
            {
                GlobalVar.LoadData("FinalBoss", FBCreated);
                MessageBox.Show($"Delete {columnName} {name} successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BackFB_Click(object sender, EventArgs e)
        {
            GetSelectedFinalBossName();
            this.previousForm.Show();
            this.Close();
        }

        private void NameFB_TextChanged(object sender, EventArgs e)
        {

        }

        private void LifeFB_TextChanged(object sender, EventArgs e)
        {
        }

        private void DamageFB_TextChanged(object sender, EventArgs e)
        {
        }

        private void VelocityFB_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
