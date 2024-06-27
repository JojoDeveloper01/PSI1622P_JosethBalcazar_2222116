using System.Data.SQLite;

namespace Tanna

{

    public partial class Play : Form

    {
        bool goLeft, goRight, goUp, goDown, gameOver;
        string facing = "up";
        int playerHealth = 100;
        int speed = 10;
        int ammo = 10;
        int Enemiespeed = 3;
        int score;
        Random randNum = new Random();
        List<PictureBox> EnemiesList = new List<PictureBox>();

        private int gameId;
        private string finalBossName;
        private string worldName;
        private List<int> enemyIds;
        private List<string> enemyNames;

        public Play()

        {
            InitializeComponent();
            RestartGame();
            GetGameDetails();
        }

        private void GetGameDetails()
        {
            string gameName = GlobalVar.SelectedGameName;

            // Consultar o ID do jogo, nome do boss final e nome do mundo
            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.CommandText = @"
                SELECT g.id, b.name AS final_boss_name, w.name AS world_name
                FROM Game g
                JOIN FinalBoss b ON g.FinalBoss_id = b.id
                JOIN World w ON g.World_id = w.id
                WHERE g.name = @gameName";
                cmd.Parameters.AddWithValue("@gameName", gameName);

                using (SQLiteDataReader reader = Program.ExecuteQuery(cmd))
                {
                    if (reader.Read())
                    {
                        gameId = reader.GetInt32(0);
                        finalBossName = reader.GetString(1);
                        worldName = reader.GetString(2);
                    }
                }
            }

            // Consultar os IDs dos inimigos do jogo
            enemyIds = new List<int>();
            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.CommandText = @"
                SELECT enemy_id
                FROM Game_Enemies
                WHERE game_id = @gameId";
                cmd.Parameters.AddWithValue("@gameId", gameId);

                using (SQLiteDataReader reader = Program.ExecuteQuery(cmd))
                {
                    while (reader.Read())
                    {
                        enemyIds.Add(reader.GetInt32(0));
                    }
                }
            }

            // Consultar os nomes dos inimigos com base nos IDs
            enemyNames = new List<string>();
            foreach (int enemyId in enemyIds)
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.CommandText = @"
                    SELECT name
                    FROM Enemies
                    WHERE id = @enemyId";
                    cmd.Parameters.AddWithValue("@enemyId", enemyId);

                    using (SQLiteDataReader reader = Program.ExecuteQuery(cmd))
                    {
                        if (reader.Read())
                        {
                            enemyNames.Add(reader.GetString(0));
                        }
                    }
                }
            }

            // Exibir os resultados para verificação (opcional)
            MessageBox.Show($"Game ID: {gameId}\nFinal Boss: {finalBossName}\nWorld: {worldName}\nEnemies: {string.Join(", ", enemyNames)}");
        }

        private void AddPlayerNameLabel()
        {
            string playerName = string.IsNullOrEmpty(GlobalVar.Username) ? "Player" : GlobalVar.Username;

            // Remove o Label anterior, se existir
            Label existingLabel = player.Controls.OfType<Label>().FirstOrDefault();
            if (existingLabel != null)
            {
                player.Controls.Remove(existingLabel);
                existingLabel.Dispose();
            }

            Label playerNameLabel = new Label();
            playerNameLabel.Text = playerName;
            playerNameLabel.ForeColor = Color.White;
            playerNameLabel.Font = new Font("Arial", 10, FontStyle.Bold);
            playerNameLabel.AutoSize = true;
            player.Controls.Add(playerNameLabel);
            playerNameLabel.BringToFront();
            playerNameLabel.Location = new Point((player.Width - playerNameLabel.Width) / 2, 0);
        }

        private void MainTimerEvent(object sender, EventArgs e)

        {

            if (playerHealth > 1)

            {
                healthBar.Value = playerHealth;
            }

            else

            {

                gameOver = true;

                player.Image = Properties.Resources.dead;

                GameTimer.Stop();

            }

            txtAmmo.Text = "Ammo: " + ammo;

            txtScore.Text = "Kills: " + score;

            // Movimento do jogador principal

            if (goLeft == true && player.Left > 0)

            {

                player.Left -= speed;

            }

            if (goRight == true && player.Left + player.Width < this.ClientSize.Width)

            {

                player.Left += speed;

            }

            if (goUp == true && player.Top > 45)

            {

                player.Top -= speed;

            }

            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)

            {

                player.Top += speed;

            }

            // Movimento e interação com os Enemies

            foreach (Control x in this.Controls)

            {

                if (x is PictureBox && (string)x.Tag == "ammo")

                {

                    if (player.Bounds.IntersectsWith(x.Bounds))

                    {

                        this.Controls.Remove(x);

                        x.Dispose(); // Dispose o controle removido

                        ammo += 5;

                    }

                }

                if (x is PictureBox && (string)x.Tag == "Enemy")

                {

                    if (player.Bounds.IntersectsWith(x.Bounds))

                    {

                        playerHealth -= 1;

                    }

                    // Movimento dos Enemies e mudança de cor

                    if (x.Left > player.Left)

                    {

                        x.Left -= Enemiespeed;

                        ((PictureBox)x).Image = Properties.Resources.zleft;

                    }

                    if (x.Left < player.Left)

                    {

                        x.Left += Enemiespeed;

                        ((PictureBox)x).Image = Properties.Resources.zright;

                    }

                    if (x.Top > player.Top)

                    {

                        x.Top -= Enemiespeed;

                        ((PictureBox)x).Image = Properties.Resources.zup;

                    }

                    if (x.Top < player.Top)

                    {

                        x.Top += Enemiespeed;

                        ((PictureBox)x).Image = Properties.Resources.zdown;

                    }

                }

                foreach (Control j in this.Controls)

                {

                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "Enemy")

                    {

                        if (x.Bounds.IntersectsWith(j.Bounds))

                        {

                            score++;

                            this.Controls.Remove(j);

                            ((PictureBox)j).Dispose();

                            this.Controls.Remove(x);

                            ((PictureBox)x).Dispose();

                            EnemiesList.Remove(((PictureBox)x));

                            MakeEnemies();

                        }

                    }

                }

            }

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {

            if (gameOver == true)
            {
                return;
            }

            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.left;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                player.Image = Properties.Resources.right;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                player.Image = Properties.Resources.up;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                player.Image = Properties.Resources.down;
            }



        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
            {
                ammo--;
                ShootBullet(facing);


                if (ammo < 1)
                {
                    DropAmmo();
                }
            }

            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }

        }

        private void ShootBullet(string direction)

        {

            Bullet shootBullet = new Bullet();

            shootBullet.direction = direction;

            shootBullet.bulletLeft = player.Left + (player.Width / 2);

            shootBullet.bulletTop = player.Top + (player.Height / 2);

            shootBullet.MakeBullet(this);

        }

        private void MakeEnemies()

        {

            PictureBox Enemy = new PictureBox();

            Enemy.Tag = "Enemy";

            Enemy.Image = Properties.Resources.zdown; // Imagem inicial

            Enemy.Left = randNum.Next(0, 900);

            Enemy.Top = randNum.Next(0, 800);

            Enemy.SizeMode = PictureBoxSizeMode.AutoSize;

            this.Controls.Add(Enemy);

            Enemy.BringToFront();

            // Adicionar um Panel acima do PictureBox para cobrir a imagem

            Panel coverPanel = new Panel();

            coverPanel.BackColor = GetRandomColor(); // Cor aleatória para o painel de cobertura

            coverPanel.Size = Enemy.Size;

            Enemy.Controls.Add(coverPanel); // Adiciona o Panel como filho do PictureBox

            coverPanel.Dock = DockStyle.Fill; // Ocupa todo o espaço do PictureBox

            coverPanel.BringToFront(); // Coloca o Panel à frente da imagem do zumbi

            // Adicionar um Label para mostrar o nome do Enemy

            Label nameLabel = new Label();

            nameLabel.Text = "Enemy " + (EnemiesList.Count + 1); // Nome do Enemy (exemplo: "Enemy 1", "Enemy 2", etc.)

            nameLabel.ForeColor = Color.White; // Cor do texto

            nameLabel.Font = new Font("Arial", 10, FontStyle.Bold); // Fonte e tamanho do texto

            nameLabel.AutoSize = true;

            Enemy.Controls.Add(nameLabel); // Adiciona o Label como filho do PictureBox

            nameLabel.BringToFront(); // Coloca o Label à frente do Panel de cobertura

            // Centraliza o Label na parte superior do PictureBox

            nameLabel.Location = new Point((Enemy.Width - nameLabel.Width) / 2, 0);

            EnemiesList.Add(Enemy);

        }

        private Color GetRandomColor()

        {

            Random rand = new Random();

            return Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));

        }

        private void DropAmmo()

        {

            PictureBox ammo = new PictureBox();

            ammo.Image = Properties.Resources.ammo_Image;

            ammo.SizeMode = PictureBoxSizeMode.AutoSize;

            ammo.Left = randNum.Next(10, this.ClientSize.Width - ammo.Width);

            ammo.Top = randNum.Next(60, this.ClientSize.Height - ammo.Height);

            ammo.Tag = "ammo";

            this.Controls.Add(ammo);

            ammo.BringToFront();

            player.BringToFront();

        }

        private void RestartGame()

        {

            player.Image = Properties.Resources.up;

            foreach (PictureBox i in EnemiesList)

            {

                this.Controls.Remove(i);

            }

            EnemiesList.Clear();

            for (int i = 0; i < 3; i++)

            {

                MakeEnemies();

            }

            goUp = false;

            goDown = false;

            goLeft = false;

            goRight = false;

            gameOver = false;

            playerHealth = 100;

            score = 0;

            ammo = 10;

            AddPlayerNameLabel();

            GameTimer.Start();

        }

    }

}
