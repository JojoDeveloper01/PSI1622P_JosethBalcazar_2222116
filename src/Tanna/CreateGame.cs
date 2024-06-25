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
using System.Xml.Linq;

namespace Tanna
{
    public partial class CreateGame : Form
    {
        private Form previousForm;
        public CreateGame(Form previousForm)
        {
            InitializeComponent();
            GlobalVar.LoadData("Game", GamesCreated);
            this.previousForm = previousForm;
        }

        private void AddGame_Click(object sender, EventArgs e)
        {
            string nameGame = CreatedGameName.Text;

            if (string.IsNullOrWhiteSpace(nameGame))
            {
                MessageBox.Show("The fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            int playerId = GlobalVar.ID;

            using (var transaction = Program.conn.BeginTransaction())
            {
                try
                {
                    if (GlobalVar.Create("Game", new Dictionary<string, string>
                    {
                        { "name", nameGame },
                        { "world_id", worldId.ToString() },
                        { "finalBoss_id", finalBossId.ToString() }
                    }, playerId))
                    {
                        int gameId = GlobalVar.GetLastInsertId("Game");

                        foreach (var enemyId in GlobalVar.SelectedEnemiesIds)
                        {
                            CreateGameEnemiesAssociation(gameId, enemyId);
                        }

                        transaction.Commit();
                        GlobalVar.LoadData("Game", GamesCreated);
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

        private void EditWorld_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateWorld createWorld = new(this);
            createWorld.ShowDialog();
        }

        private void EditFB_Click(object sender, EventArgs e)
        {

            this.Hide();
            CreateFinalBoss createFB = new(this);
            createFB.ShowDialog();
        }

        private void EditEnemies_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateEnemies createEnemies = new(this);
            createEnemies.ShowDialog();
        }

        private void UpdateProperties_Click(object sender, EventArgs e)
        {
            GlobalVar.LoadData("SelectedGames", SelectedProperties);
        }

        private void UpdateGamesCreated_Click(object sender, EventArgs e)
        {
            GlobalVar.LoadData("Game", GamesCreated);
        }
        
        public void CreateGameEnemiesAssociation(int gameId, int enemyId)
        {
            const string sql = "INSERT INTO Game_Enemies (game_id, enemy_id) VALUES (@gameId, @enemyId)";
            using (var cmd = new SQLiteCommand(sql, Program.conn))
            {
                cmd.Parameters.AddWithValue("@gameId", gameId);
                cmd.Parameters.AddWithValue("@enemyId", enemyId);
                cmd.ExecuteNonQuery();
            }
        }

        private void DelGame_Click(object sender, EventArgs e)
        {
            string name = NameDelGame.Text;
            string columnName = "Game";

            if (GlobalVar.Delete(name, columnName))
            {
                GlobalVar.LoadData("Game", GamesCreated);
                MessageBox.Show($"Delete {columnName} {name} successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BackGame_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }
    }
}
