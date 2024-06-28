using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

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

            if (!int.TryParse(size, out int sizeValue))
            {
                MessageBox.Show("Size must be numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (sizeValue > 1500 || sizeValue < 1200)
            {
                MessageBox.Show("Size must be between 1200 and 1500.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (GlobalVar.IsNameAlreadyExists("World", name))
            {
                MessageBox.Show($"An entity with the name '{name}' already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check duration only if it's not empty
            if (!string.IsNullOrWhiteSpace(duration))
            {
                if (!int.TryParse(duration, out int durationValue))
                {
                    MessageBox.Show("Duration must be numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (durationValue < 20)
                {
                    MessageBox.Show("Duration must be at least 20.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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

        private void Update_Click(object sender, EventArgs e)
        {
            if (WorldsCreated.CurrentRow == null)
            {
                MessageBox.Show("No row selected for update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow row = WorldsCreated.CurrentRow;

            if (!int.TryParse(row.Cells["id"].Value?.ToString(), out int itemId))
            {
                MessageBox.Show("Invalid item ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = row.Cells["name"].Value?.ToString();
            string size = row.Cells["size"].Value?.ToString();
            string duration = row.Cells["duration"].Value?.ToString(); // Assuming there's a column for duration

            // Debug output to display row information
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(size))
            {
                MessageBox.Show("All fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate size
            if (!Regex.IsMatch(size, @"^\d+$"))
            {
                MessageBox.Show("Size must be numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int sizeValue;
            if (!int.TryParse(size, out sizeValue))
            {
                MessageBox.Show("Invalid size format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (sizeValue > 1500 || sizeValue < 1200)
            {
                MessageBox.Show($"Size must be between 1200 and 1500. Current size: {sizeValue}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate duration if it exists and is not empty
            if (!string.IsNullOrWhiteSpace(duration))
            {
                if (!Regex.IsMatch(duration, @"^\d+$"))
                {
                    MessageBox.Show("Duration must be numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int durationValue;
                if (!int.TryParse(duration, out durationValue))
                {
                    MessageBox.Show("Invalid duration format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (durationValue < 20)
                {
                    MessageBox.Show("Duration must be at least 20.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            int playerId = GlobalVar.ID; // Obtain the currently logged in player's ID

            using (var transaction = Program.conn.BeginTransaction())
            {
                try
                {
                    // Build the dictionary of columns
                    var columns = new Dictionary<string, string>
            {
                { "name", name },
                { "size", sizeValue.ToString() }
            };

                    // Add duration if not empty
                    if (!string.IsNullOrWhiteSpace(duration))
                    {
                        columns.Add("duration", duration);
                    }
                    else
                    {
                        // If duration is empty, set it to null in the database
                        columns.Add("duration", null);
                    }

                    // Assuming the method UpdateWorld exists to handle updating the database
                    bool updateResult = GlobalVar.Update("World", itemId, columns, playerId);
                    if (updateResult)
                    {
                        transaction.Commit();
                        MessageBox.Show($"World {name} updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Failed to update World {name}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error updating World: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
