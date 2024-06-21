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
    public partial class CreateGame : Form
    {
        public CreateGame()
        {
            InitializeComponent();
            GlobalVar.LoadData("Games Created", GamesCreated);
        }

        private void EditWorld_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateWorld createWorld = new();
            createWorld.ShowDialog();
            this.Show();
        }

        private void EditFB_Click(object sender, EventArgs e)
        {

            this.Hide();
            CreateFinalBoss createFB = new();
            createFB.ShowDialog();
            this.Show();
        }

        private void EditEnemies_Click(object sender, EventArgs e)
        {

            this.Hide();
            CreateEnemies createEnemies = new();
            createEnemies.ShowDialog();
            this.Show();
        }

        private void CreateGame_Click(object sender, EventArgs e)
        {
            string finalBossName = GlobalVar.SelectedFBName;
            if (string.IsNullOrEmpty(finalBossName))
            {
                MessageBox.Show("A valid Final Boss must be selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int finalBossId = GlobalVar.GetIdByName("FinalBoss", finalBossName);
            if (finalBossId == -1)
            {
                MessageBox.Show("A valid Final Boss must be selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> enemyNames = GlobalVar.SelectedEnemiesName;
            if (enemyNames.Count == 0)
            {
                MessageBox.Show("At least one group of Enemies must be selected before creating a Game.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<int> enemyIds = new List<int>();
            foreach (string name in enemyNames)
            {
                int id = GlobalVar.GetIdByName("Enemies", name);
                if (id != -1)
                {
                    enemyIds.Add(id);
                }
            }
            if (enemyIds.Count == 0)
            {
                MessageBox.Show("At least one group of Enemies must be selected before creating a Game.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string worldName = GlobalVar.SelectedWorldName;
            if (string.IsNullOrEmpty(worldName))
            {
                MessageBox.Show("A valid World must be selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int worldId = GlobalVar.GetIdByName("World", worldName);
            if (worldId == -1)
            {
                MessageBox.Show("A valid World must be selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int playerId = GlobalVar.ID;

            using (var transaction = Program.conn.BeginTransaction())
            {
                try
                {
                    if (GlobalVar.Create("Game", new Dictionary<string, string>
            {
                { "world_id", worldId.ToString() },
                { "finalBoss_id", finalBossId.ToString() }
            }, playerId))
                    {
                        transaction.Commit();
                        GlobalVar.LoadData("Games Created", GamesCreated);
                        MessageBox.Show("Game created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        transaction.Rollback();
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error creating game: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
