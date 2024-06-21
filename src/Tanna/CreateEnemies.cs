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
        public CreateEnemies()
        {
            InitializeComponent();
            GlobalVar.LoadData("Enemies", EnemiesCreated);
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

            if (GlobalVar.IsNameAlreadyExists("Enemies", name))
            {
                MessageBox.Show($"An Enemies group with the name '{name}' already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int playerId = GlobalVar.ID; // Obter o ID do jogador atualmente logado

            if (GlobalVar.Create(columnCreate, new Dictionary<string, string> { { "name", name }, { "amount", amount }, { "life", life } }, playerId)) // Passa playerId para o método Create
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

        private void GetSelectedEnemyNames()
        {
            GlobalVar.SelectedEnemiesName.Clear();
            foreach (DataGridViewRow row in EnemiesCreated.SelectedRows)
            {
                GlobalVar.SelectedEnemiesName.Add(row.Cells["Name"].Value.ToString());
            }

            if (GlobalVar.SelectedEnemiesName.Count == 0)
            {
                MessageBox.Show("No enemies selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

    }
}
