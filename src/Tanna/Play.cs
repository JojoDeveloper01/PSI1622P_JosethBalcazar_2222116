using System;
using System.Data.SQLite;
using System.Text;
using Timer = System.Windows.Forms.Timer;

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
        int bullet = 10;
        Random randNum = new Random();
        List<PictureBox> EnemiesList = new List<PictureBox>();

        private ProgressBar finalBossHealthBar;

        private Label lblGameInfo;
        private int gameId;
        private string gameName;

        private string finalBossName;
        private int finalBossLife;
        private int finalBossVelocity;
        private int finalBossDamage;
        
        private string worldName;
        private Size newWorldSize;
        private int? worldDuration;
        private System.Windows.Forms.Timer timer;
        private Label lblTimeRemaining;

        private List<string> enemyNames = new List<string>();
        private List<int> enemyAmounts = new List<int>();
        private List<int> enemyIds = new List<int>();

        private Dictionary<string, int> remainingEnemies = new Dictionary<string, int>();
        private Dictionary<string, int> defeatedEnemiesCount = new Dictionary<string, int>();
        private Dictionary<string, Color> enemyColors = new Dictionary<string, Color>();

        public Play()
        {
            InitializeComponent();
            InitializeEnemyCounts();
            AddPlayerNameLabel();

            // Chamar GetGameDetails para obter os detalhes do jogo
            GetGameDetails();

            // Configurar o nome e o tamanho da janela
            WorldOptions();

            RestartGame();
        }

        private void InitializeEnemyCounts()
        {
            remainingEnemies.Clear(); // Limpar o dicionário antes de inicializar

            // Inicializar o dicionário de inimigos restantes
            for (int i = 0; i < enemyNames.Count; i++)
            {
                remainingEnemies.Add(enemyNames[i], enemyAmounts[i]);
            }
        }

        private void WorldOptions()
        {
            this.Text = worldName;
            this.ClientSize = newWorldSize;

            if (worldDuration.HasValue && worldDuration.Value > 0)
            {
                timer = new Timer();
                timer.Interval = 1000; // Intervalo de 1 segundo (1000 ms)
                timer.Tick += Timer_Tick;
                timer.Start();
            }

            // Adicionar um label para mostrar o tempo restante
            lblTimeRemaining = new Label();
            lblTimeRemaining.AutoSize = true;

            // Calcular a posição para colocar a label no canto superior direito
            // Aumentar o tamanho da fonte
            lblTimeRemaining.Font = new Font(lblTimeRemaining.Font.FontFamily, 16, FontStyle.Bold); // Exemplo de tamanho de fonte 16 e negrito

            // Calcular a posição para colocar a label no canto inferior direito
            int xPosition = this.ClientSize.Width / 7; // 10 pixels de margem à direita
            int yPosition = 10; // 10 pixels de margem do fundo
            lblTimeRemaining.Location = new Point(xPosition, yPosition);

            lblTimeRemaining.ForeColor = Color.White; // Definir a cor do texto para branco
            this.Controls.Add(lblTimeRemaining);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (worldDuration.HasValue)
            {
                worldDuration -= 1; // Reduzir o tempo restante em 1 segundo

                if (worldDuration <= 0)
                {
                    timer.Stop();
                    gameOver = true;
                    playerHealth = 0;
                    this.Hide();
                    Lose lose= new();
                    lose.ShowDialog();
                }

                // Atualizar o label com o tempo restante
                UpdateTimeRemainingLabel();
            }
        }

        private void UpdateTimeRemainingLabel()
        {
            if (worldDuration.HasValue)
            {
                lblTimeRemaining.Text = $"{worldDuration}s";
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
                           b.name AS final_boss_name, b.life AS final_boss_life, 
                           b.velocity AS final_boss_velocity, b.damage AS final_boss_damage,
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
                        finalBossVelocity = reader.GetInt32(4);
                        finalBossDamage = reader.GetInt32(5);
                        worldName = reader.GetString(6);
                        int worldSizeValue = reader.GetInt32(7);

                        // Ajustar o tamanho do mundo para ser horizontal   
                        int width = worldSizeValue;
                        int height = (int)(width * 0.6); // Ajuste a proporção conforme necessário
                        newWorldSize = new Size(width, height);

                        // Obter world_duration e armazenar em worldDuration
                        worldDuration = reader.IsDBNull(9) ? null : (int?)reader.GetInt32(9);
                    }
                }
            }

            // Consultar os IDs, nomes, quantidades e vidas dos inimigos do jogo
            enemyIds = new List<int>();
            enemyNames = new List<string>();
            enemyAmounts = new List<int>();

            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.CommandText = @"
            SELECT e.id, e.name, e.amount
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
                    }
                }
            }

            // Mostrar informações do jogo em um MessageBox (para depuração)
            MessageBox.Show($"Game Name: {gameName}\n\nWorld:\nName: {worldName}\nSize: {newWorldSize}\nDuration: {worldDuration} seconds\n\nFinal Boss:\nName: {finalBossName}\nLife: {finalBossLife}\nVelocity: {finalBossVelocity}\nDamage: {finalBossDamage}\n\nEnemies:\n{GetEnemiesInfo()}");

            // Função auxiliar para formatar a informação dos inimigos
            string GetEnemiesInfo()
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < enemyIds.Count; i++)
                {
                    sb.AppendLine($"ID: {enemyIds[i]}, Name: {enemyNames[i]}, Amount: {enemyAmounts[i]}");
                }
                return sb.ToString();
            }
        }

        private void UpdateGameInfo()
        {

            // Constrói a string com as informações do jogo
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"World: {worldName}");
            sb.AppendLine(" ");
            sb.AppendLine($"Enemies:");

            bool allEnemiesDefeated = true;

            // Iterar sobre todos os tipos de inimigos conhecidos
            foreach (var enemyName in enemyNames)
            {
                int totalEnemies = enemyAmounts[enemyNames.IndexOf(enemyName)];
                int defeatedEnemies = defeatedEnemiesCount.ContainsKey(enemyName) ? defeatedEnemiesCount[enemyName] : 0;
                int remainingEnemiesCount = totalEnemies - defeatedEnemies;

                sb.AppendLine($"{enemyName}: {remainingEnemiesCount}/{totalEnemies}");

                if (remainingEnemiesCount > 0)
                {
                    allEnemiesDefeated = false;
                }
            }

            // Verifica se todos os inimigos foram derrotados antes de iniciar o Final Boss
            if (allEnemiesDefeated)
            {
                MakeFinalBoss();
            }

            // Atualiza o texto da label com as informações
            lblGameInfo.Text = sb.ToString();
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
                this.Hide();
                Lose lose = new();
                lose.ShowDialog();
            }

            txtAmmo.Text = "Ammo: " + ammo;
            txtScore.Text = "Kills: " + score;

            // Movimento do jogador principal
            PlayerMoviment();

            // Movimento e interação com os Enemies
            EnemyMovement();

        }

        private void PlayerMoviment()
        {
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
                MessageBox.Show("Game Over!");
                RestartGame();
            }
        }

        private void EnemyMovement()
        {
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

                    PictureBox enemyPictureBox = (PictureBox)x; // Cast seguro para PictureBox

                    if (enemyPictureBox.Left > player.Left)
                    {
                        enemyPictureBox.Left -= Enemiespeed;
                        enemyPictureBox.Image = Properties.Resources.zleft;
                    }
                    if (enemyPictureBox.Left < player.Left)
                    {
                        enemyPictureBox.Left += Enemiespeed;
                        enemyPictureBox.Image = Properties.Resources.zright;
                    }
                    if (enemyPictureBox.Top > player.Top)
                    {
                        enemyPictureBox.Top -= Enemiespeed;
                        enemyPictureBox.Image = Properties.Resources.zup;
                    }
                    if (enemyPictureBox.Top < player.Top)
                    {
                        enemyPictureBox.Top += Enemiespeed;
                        enemyPictureBox.Image = Properties.Resources.zdown;
                    }
                }

                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && x is PictureBox && (string)x.Tag == "Enemy" && (string)j.Tag == "bullet")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;

                            // Determinar qual tipo de inimigo foi derrotado e incrementar o contador correspondente no dicionário
                            string enemyType = ((PictureBox)x).Name; // Nome do inimigo determinado durante a criação

                            int count;
                            if (defeatedEnemiesCount.TryGetValue(enemyType, out count))
                            {
                                defeatedEnemiesCount[enemyType] = count + 1;
                            }
                            else
                            {
                                defeatedEnemiesCount.Add(enemyType, 1);
                            }

                            // Remover o inimigo e a bala da interface
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            EnemiesList.Remove((PictureBox)x);
                            MakeEnemies();
                            UpdateGameInfo();
                        }
                    }
                }

                // Interagir com o Final Boss, se existir
                if (x is PictureBox && (string)x.Tag == "FinalBoss")
                {
                    PictureBox finalBossPictureBox = (PictureBox)x;

                    // Verificar colisão do jogador com o Final Boss
                    if (player.Bounds.IntersectsWith(finalBossPictureBox.Bounds))
                    {
                        playerHealth -= finalBossDamage;
                    }

                    // Movimento do Final Boss em direção ao jogador
                    if (finalBossPictureBox.Left > player.Left)
                    {
                        finalBossPictureBox.Left -= finalBossVelocity;
                    }
                    if (finalBossPictureBox.Left < player.Left)
                    {
                        finalBossPictureBox.Left += finalBossVelocity;
                    }
                    if (finalBossPictureBox.Top > player.Top)
                    {
                        finalBossPictureBox.Top -= finalBossVelocity;
                    }
                    if (finalBossPictureBox.Top < player.Top)
                    {
                        finalBossPictureBox.Top += finalBossVelocity;
                    }

                    foreach (Control j in this.Controls)
                    {
                        if (j is PictureBox && (string)j.Tag == "bullet")
                        {
                            if (finalBossPictureBox.Bounds.IntersectsWith(j.Bounds))
                            {
                                // Reduzir a vida do Final Boss
                                finalBossLife -= 10; // ou qualquer valor apropriado

                                // Atualizar a barra de vida do Final Boss
                                finalBossHealthBar.Value = finalBossLife;

                                // Remover a bala
                                this.Controls.Remove(j);
                                ((PictureBox)j).Dispose();

                                // Verificar se o Final Boss foi derrotado
                                if (finalBossLife <= 0)
                                {
                                    this.Controls.Remove(finalBossPictureBox);
                                    finalBossPictureBox.Dispose();

                                    this.Hide();
                                    Win win = new();
                                    win.ShowDialog();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void MakeEnemies()
        {
            List<string> availableEnemies = remainingEnemies.Where(kvp => kvp.Value > 0).Select(kvp => kvp.Key).ToList();

            bool isReady = true;

            if (availableEnemies.Count == 0)
            {
                for (int i = 0; i < enemyNames.Count; i++)
                {
                    if (availableEnemies.Contains(enemyNames[i]))
                    {
                        isReady = false;
                        break;
                    }
                }

                if (!isReady)
                {
                    MakeFinalBoss();
                }

                return; 
            }

            string enemyName = availableEnemies[randNum.Next(availableEnemies.Count)];

            // Verificar se a cor para este tipo de inimigo já foi atribuída, senão, gerar uma nova cor
            if (!enemyColors.ContainsKey(enemyName))
            {
                enemyColors[enemyName] = GetRandomColor(); // Gerar e armazenar a cor aleatória
            }

            Color enemyColor = enemyColors[enemyName]; // Obter a cor para este tipo de inimigo

            PictureBox Enemy = new PictureBox
            {
                Tag = "Enemy",
                Image = Properties.Resources.zdown, // Imagem inicial
                Left = randNum.Next(0, 900),
                Top = randNum.Next(0, 800),
                SizeMode = PictureBoxSizeMode.StretchImage, // Ajustar para que a imagem se ajuste ao tamanho
                Size = new Size(80, 80), // Definir tamanho inicial do PictureBox
                Name = enemyName // Definir o nome do PictureBox
            };

            // Criar um Panel para cobrir o inimigo com a cor principal
            Panel coverPanel = new Panel
            {
                BackColor = enemyColor, // Atribuir a cor aleatória gerada ou recuperada
                Size = new Size(Enemy.Width, Enemy.Height),
                Dock = DockStyle.Top
            };
            Enemy.Controls.Add(coverPanel); // Adicionar o Panel como filho do PictureBox

            // Adicionar um Label para mostrar o nome do Enemy com fundo preto e texto branco
            Label nameLabel = new Label
            {
                Text = enemyName, // Nome do inimigo
                ForeColor = Color.White, // Cor do texto
                BackColor = Color.Gray, // Cor do fundo
                Font = new Font("Arial", 9, FontStyle.Bold), // Fonte e tamanho do texto inicial
                AutoSize = false, // Desativar o ajuste automático de tamanho
                TextAlign = ContentAlignment.MiddleCenter // Alinhar o texto ao centro
            };
            FitLabelFontSize(nameLabel, coverPanel.Size); // Ajustar o tamanho do Label para caber no Panel
            nameLabel.Location = new Point((coverPanel.Width - nameLabel.Width) / 2, 0);
            coverPanel.Controls.Add(nameLabel); // Adicionar o Label como filho do Panel de cobertura

            this.Controls.Add(Enemy); // Adicionar o PictureBox à janela principal
            Enemy.BringToFront(); // Colocar o PictureBox à frente de outros controles

            EnemiesList.Add(Enemy); // Adicionar o PictureBox à lista de inimigos

            remainingEnemies[enemyName]--; // Atualizar a quantidade restante de inimigos deste tipo
        }

        private void MakeFinalBoss()
        {
            // Definir parâmetros do Final Boss
            ammo += 20;
            speed += finalBossVelocity;
            Color bossColor = GetRandomColor();

            // Criar o PictureBox do Final Boss
            PictureBox finalBoss = new PictureBox
            {
                Tag = "FinalBoss",
                Image = Properties.Resources.zdown, // Imagem do chefe final
                Left = randNum.Next(0, this.ClientSize.Width - 120), // Ajustar para não sair da tela
                Top = randNum.Next(0, this.ClientSize.Height - 200), // Ajustar para não sair da tela
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(120, 120),
                Name = finalBossName
            };

            // Adicionar o Final Boss à tela
            this.Controls.Add(finalBoss);

            // Criar um Panel para cobrir o Final Boss com a cor principal
            Panel coverPanel = new Panel
            {
                BackColor = bossColor,
                Size = new Size(finalBoss.Width, finalBoss.Height),
                Dock = DockStyle.Top
            };
            finalBoss.Controls.Add(coverPanel);

            // Adicionar um Label para mostrar o nome do Final Boss
            Label nameLabel = new Label
            {
                Text = finalBossName,
                ForeColor = Color.White,
                BackColor = Color.Black,
                Font = new Font("Arial", 12, FontStyle.Bold),
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter
            };
            nameLabel.Location = new Point((coverPanel.Width - nameLabel.Width) / 2, 0);
            coverPanel.Controls.Add(nameLabel);

            // Inicializar a barra de vida do Final Boss
            finalBossHealthBar = new ProgressBar
            {
                Maximum = finalBossLife,
                Value = finalBossLife,
                Size = new Size(this.ClientSize.Width / 2, 20), // Largura da barra de vida
                Location = new Point((this.ClientSize.Width - this.ClientSize.Width / 2) / 2, this.ClientSize.Height - 30) // Posicionamento no rodapé da tela
            };

            // Adicionar a barra de vida à tela
            this.Controls.Add(finalBossHealthBar);
            finalBossHealthBar.BringToFront();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Final Boss: {finalBossName}");
            sb.AppendLine($"Health: {finalBossLife}");
            sb.AppendLine($"Velocity: {finalBossVelocity}");
            sb.AppendLine($"Damage: {finalBossDamage}");

            // Configuração dos labels no formulário
            Label lblFinalBoss = new Label();
            lblFinalBoss.Text = sb.ToString();
            lblFinalBoss.AutoSize = true; // Ajusta automaticamente o tamanho do label
            lblFinalBoss.Location = new Point(10, 650);
            lblFinalBoss.ForeColor = Color.White;
            lblFinalBoss.Font = new Font("Arial", 10, FontStyle.Bold);

            // Adiciona o label ao formulário
            this.Controls.Add(lblFinalBoss);
        }


        /*----------------------------------------*/

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
                UpdateGameInfo();
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

        private void ShootBullet(string direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = player.Left + (player.Width / 2);
            shootBullet.bulletTop = player.Top + (player.Height / 2);
            shootBullet.MakeBullet(this);
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

        private void FitLabelFontSize(Label label, Size panelSize)
        {
            float fontSize = 8.5f;
            Font f = new Font(label.Font.Name, fontSize, label.Font.Style);
            SizeF size = TextRenderer.MeasureText(label.Text, f);

            while (size.Width < panelSize.Width - 2 && size.Height < panelSize.Height - 2)
            {
                fontSize += 0.5f;
                f = new Font(label.Font.Name, fontSize, label.Font.Style);
                size = TextRenderer.MeasureText(label.Text, f);
            }

            label.Font = new Font(label.Font.Name, fontSize - 1, label.Font.Style);
        }

        private Color GetRandomColor()
        {
            Random rand = new Random();
            return Color.FromArgb(randNum.Next(100, 256), randNum.Next(100, 256), randNum.Next(100, 256));
        }
    }
}
