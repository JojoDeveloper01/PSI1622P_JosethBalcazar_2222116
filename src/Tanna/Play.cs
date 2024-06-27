using System.Data.SQLite;
using System.Text;

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

        private Label lblGameInfo;
        private int gameId;
        private string gameName;
        private string finalBossName;
        private int finalBossLife;
        private int finalBossStamina;
        private int finalBossVelocity;
        private int finalBossEnergy;
        private string worldName;
        private string worldSize;
        private int? worldDuration;

        private List<string> enemyNames = new List<string>();
        private List<int> enemyAmounts = new List<int>();
        private List<int> enemyIds = new List<int>();
        private List<int> enemyLives = new List<int>();

        public Play()
        {
            InitializeComponent();
            AddPlayerNameLabel();
            GetGameDetails();
            InitializeEnemyCounts();
            RestartGame();
        }

        private Dictionary<string, int> remainingEnemies = new Dictionary<string, int>();

        private void InitializeEnemyCounts()
        {
            // Inicializar o dicionário de inimigos restantes
            remainingEnemies.Clear();
            for (int i = 0; i < enemyNames.Count; i++)
            {
                remainingEnemies[enemyNames[i]] = enemyAmounts[i];
            }
        }

        private void GetGameDetails()
        {
            gameName = GlobalVar.SelectedGameName;

            // Consultar detalhes do jogo, boss final, mundo e inimigos
            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.CommandText = @"
             SELECT g.id, g.name AS game_name,
                           b.name AS final_boss_name, b.life AS final_boss_life, b.stamina AS final_boss_stamina, 
                           b.velocity AS final_boss_velocity, b.energy AS final_boss_energy,
                           w.name AS world_name, w.size AS world_size, w.duration AS world_duration
                    FROM Game g
                    JOIN FinalBoss b ON g.FinalBoss_id = b.id
                    JOIN World w ON g.World_id = w.id
                    WHERE g.name = @gameName;";
                cmd.Parameters.AddWithValue("@gameName", gameName);

                using (SQLiteDataReader reader = Program.ExecuteQuery(cmd))
                {
                    if (reader.Read())
                    {
                        gameId = reader.GetInt32(0);
                        gameName = reader.GetString(1);
                        finalBossName = reader.GetString(2);
                        finalBossLife = reader.GetInt32(3);
                        finalBossStamina = reader.GetInt32(4);
                        finalBossVelocity = reader.GetInt32(5);
                        finalBossEnergy = reader.GetInt32(6);
                        worldName = reader.GetString(7);
                        worldSize = reader.GetInt32(8).ToString();
                        // Verifica se world_duration foi retornado antes de lê-lo
                        if (!reader.IsDBNull(9))
                        {
                            worldDuration = reader.GetInt32(9);
                        }
                        else
                        {
                            worldDuration = null; // Se world_duration for NULL no banco de dados
                        }
                    }
                }
            }

            // Consultar os IDs, nomes, quantidades e vidas dos inimigos do jogo
            enemyIds = new List<int>();
            enemyNames = new List<string>();
            enemyAmounts = new List<int>();
            enemyLives = new List<int>();

            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.CommandText = @"
                SELECT e.id, e.name, e.amount, e.life
                FROM Enemies e
                JOIN Game_Enemies ge ON e.id = ge.enemy_id
                WHERE ge.game_id = @gameId";
                cmd.Parameters.AddWithValue("@gameId", gameId);

                using (SQLiteDataReader reader = Program.ExecuteQuery(cmd))
                {
                    while (reader.Read())
                    {
                        enemyIds.Add(reader.GetInt32(0));
                        enemyNames.Add(reader.GetString(1));
                        enemyAmounts.Add(reader.GetInt32(2));
                        enemyLives.Add(reader.GetInt32(3));
                    }
                }
            }

            MessageBox.Show($"Game Name: {gameName}\n\nWorld:\nName: {worldName}\nSize: {worldSize}\nDuration: {worldDuration}\n\nFinal Boss:\nName: {finalBossName}\nLife: {finalBossLife}\nStamina: {finalBossStamina}\nVelocity: {finalBossVelocity}\nEnergy: {finalBossEnergy}\n\nEnemies:\n{GetEnemiesInfo()}");

            // Aqui está uma função auxiliar para formatar a informação dos inimigos
            string GetEnemiesInfo()
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < enemyIds.Count; i++)
                {
                    sb.AppendLine($"ID: {enemyIds[i]}, Name: {enemyNames[i]}, Amount: {enemyAmounts[i]}, Life: {enemyLives[i]}");
                }
                return sb.ToString();
            }
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

            lblGameInfo = new Label();
            lblGameInfo.ForeColor = Color.White;
            lblGameInfo.Font = new Font("Arial", 10, FontStyle.Bold);
            lblGameInfo.AutoSize = true;

            lblGameInfo.Location = new Point(10, 60);

            this.Controls.Add(lblGameInfo);
            lblGameInfo.BringToFront();
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
            if (goLeft && player.Left > 0)
            {
                player.Left -= speed;
            }
            if (goRight && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }
            if (goUp && player.Top > 45)
            {
                player.Top -= speed;
            }
            if (goDown && player.Top + player.Height < this.ClientSize.Height)
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
                        x.Dispose();
                        ammo += 5;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "Enemy")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1;
                    }

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
                            string enemyName = x.Name; // Obtém o nome do inimigo
                            if (remainingEnemies.ContainsKey(enemyName))
                            {
                                remainingEnemies[enemyName]--;
                            }

                            // Remover a bala e o inimigo
                            score++;
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            EnemiesList.Remove((PictureBox)x);

                            // Criar um novo inimigo se ainda houver quantidade restante
                            MakeEnemies();

                            // Atualizar as informações do jogo
                            UpdateGameInfo();
                        }
                    }
                }
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (gameOver)
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

            if (e.KeyCode == Keys.Space && ammo > 0 && !gameOver)
            {
                ammo--;
                ShootBullet(facing);

                if (ammo < 1)
                {
                    DropAmmo();
                }
            }

            if (e.KeyCode == Keys.Enter && gameOver)
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
            UpdateGameInfo();
        }

        private void MakeEnemies()
        {
            // Selecionar um nome de inimigo aleatório que ainda tenha inimigos restantes
            List<string> availableEnemies = remainingEnemies.Where(kvp => kvp.Value > 0).Select(kvp => kvp.Key).ToList();
            if (availableEnemies.Count == 0)
            {
                return; // Nenhum inimigo restante para criar
            }

            string enemyName = availableEnemies[randNum.Next(availableEnemies.Count)];

            // Criar um novo inimigo
            PictureBox Enemy = new PictureBox
            {
                Tag = "Enemy",
                Image = Properties.Resources.zdown, // Imagem inicial
                Left = randNum.Next(0, 900),
                Top = randNum.Next(0, 800),
                SizeMode = PictureBoxSizeMode.StretchImage, // Ajustar para que a imagem se ajuste ao tamanho
                Size = new Size(80, 80), // Definir tamanho inicial do PictureBox
                Name = enemyName // Set the name of the enemy PictureBox
            };

            // Create a new coverPanel with a random color
            Panel coverPanel = new Panel
            {
                BackColor = GetRandomColor(), // Cor aleatória para o painel de cobertura
                Size = new Size(Enemy.Width, Enemy.Height),
                Dock = DockStyle.Top
            };
            Enemy.Controls.Add(coverPanel); // Adicionar o Panel como filho do PictureBox

            // Adicionar um Label para mostrar o nome do Enemy
            Label nameLabel = new Label
            {
                Text = enemyName, // Nome do inimigo
                ForeColor = Color.White, // Cor do texto
                Font = new Font("Arial", 9, FontStyle.Bold), // Fonte e tamanho do texto inicial
                AutoSize = false, // Desativar o ajuste automático de tamanho
                TextAlign = ContentAlignment.MiddleCenter // Alinhar o texto ao centro
            };
            FitLabelFontSize(nameLabel, coverPanel.Size);
            nameLabel.Location = new Point((coverPanel.Width - nameLabel.Width) / 2, 0);
            coverPanel.Controls.Add(nameLabel); // Adicionar o Label como filho do Panel de cobertura

            // Adicionar o PictureBox à janela principal
            this.Controls.Add(Enemy);
            Enemy.BringToFront(); // Colocar o PictureBox à frente de outros controles

            EnemiesList.Add(Enemy);

            // Atualizar a quantidade restante de inimigos deste tipo
            remainingEnemies[enemyName]--;

            UpdateGameInfo();
        }

        private void FitLabelFontSize(Label label, Size maxSize)
        {
            // Initial font size and font family
            int fontSize = 9; // Starting font size
            Font labelFont = label.Font;

            // Measure the text size with the initial font
            SizeF textSize = TextRenderer.MeasureText(label.Text, labelFont);

            // Reduce font size until the text fits within the maximum size
            while ((textSize.Width > maxSize.Width || textSize.Height > maxSize.Height) && fontSize > 1)
            {
                fontSize--; // Decrease font size
                labelFont = new Font(labelFont.FontFamily, fontSize, labelFont.Style); // Create new font with reduced size
                textSize = TextRenderer.MeasureText(label.Text, labelFont); // Measure text size with the new font
            }

            // Update label's font with the adjusted size
            label.Font = labelFont;
        }

        private Color GetRandomColor()
        {
            Random rand = new Random();
            return Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }

        private void UpdateGameInfo()
        {
            // Constrói a string com as informações do jogo
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Final Boss: {finalBossName}");
            sb.AppendLine($"World: {worldName}");
            sb.AppendLine($"Enemies:");

            // Iterar sobre todos os nomes de inimigos conhecidos
            foreach (var enemyName in enemyNames)
            {
                // Encontra a quantidade total de inimigos deste tipo
                int totalEnemies = enemyAmounts[enemyNames.IndexOf(enemyName)];

                // Verifica a quantidade restante no dicionário
                int remainingEnemiesCount = remainingEnemies.ContainsKey(enemyName) ? remainingEnemies[enemyName] : 0;

                sb.AppendLine($"{enemyName} {remainingEnemiesCount}/{totalEnemies}");
            }

            // Atualiza o texto da label com as informações
            lblGameInfo.Text = sb.ToString();
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

            // Garantir que os contadores de inimigos estejam inicializados corretamente
            InitializeEnemyCounts();

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
            GameTimer.Start();
        }

    }
}
