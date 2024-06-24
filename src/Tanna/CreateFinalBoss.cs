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
            string stamina = StaminaFB.Text;
            string velocity = VelocityFB.Text;
            string energy = EnergyFB.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(life) ||
                string.IsNullOrWhiteSpace(stamina) || string.IsNullOrWhiteSpace(velocity) || string.IsNullOrWhiteSpace(energy))
            {
                MessageBox.Show("All fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(life, out _) || !int.TryParse(stamina, out _) ||
                !int.TryParse(velocity, out _) || !int.TryParse(energy, out _))
            {
                MessageBox.Show("Life, Stamina, Velocity, and Energy must be numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
             { "life", life },
             { "stamina", stamina },
             { "velocity", velocity },
             { "energy", energy } }, playerId)) // Passa playerId para o método Create
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

        private void GetSelectedFinalBossName()
        {
            if (FBCreated.SelectedRows.Count > 0)
            {
                GlobalVar.SelectedFBName = FBCreated.SelectedRows[0].Cells["Name"].Value.ToString();
            }
            else
            {
                MessageBox.Show("No Final Boss selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void VoltarFB_Click(object sender, EventArgs e)
        {
            GetSelectedFinalBossName();
            this.previousForm.Show();
            this.Close();
        }
    }
}
