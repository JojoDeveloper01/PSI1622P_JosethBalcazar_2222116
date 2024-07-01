namespace Tanna
{
    partial class CreateGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            GamesCreated = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            CreatedGameName = new TextBox();
            AddGame = new Button();
            EditWorld = new Button();
            EditFB = new Button();
            EditEnemies = new Button();
            UpdateProperties = new Button();
            SelectedProperties = new DataGridView();
            label7 = new Label();
            DelGame = new Button();
            label16 = new Label();
            NameDelGame = new TextBox();
            UpdateGamesCreated = new Button();
            BackGame = new Button();
            ((System.ComponentModel.ISupportInitialize)GamesCreated).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SelectedProperties).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 0, 64);
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(49, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(266, 54);
            label1.TabIndex = 0;
            label1.Text = "Create Game";
            // 
            // GamesCreated
            // 
            GamesCreated.BackgroundColor = Color.FromArgb(64, 0, 64);
            GamesCreated.ColumnHeadersHeight = 34;
            GamesCreated.Location = new Point(324, 523);
            GamesCreated.Margin = new Padding(4, 5, 4, 5);
            GamesCreated.Name = "GamesCreated";
            GamesCreated.RowHeadersWidth = 62;
            GamesCreated.RowTemplate.Height = 25;
            GamesCreated.Size = new Size(711, 302);
            GamesCreated.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(324, 448);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(205, 38);
            label2.TabIndex = 2;
            label2.Text = "Games Created";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(64, 0, 64);
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(46, 173);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(177, 38);
            label3.TabIndex = 3;
            label3.Text = "Create Game";
            // 
            // CreatedGameName
            // 
            CreatedGameName.BackColor = Color.FromArgb(64, 0, 64);
            CreatedGameName.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CreatedGameName.ForeColor = SystemColors.ButtonFace;
            CreatedGameName.Location = new Point(49, 252);
            CreatedGameName.Margin = new Padding(4, 5, 4, 5);
            CreatedGameName.Name = "CreatedGameName";
            CreatedGameName.Size = new Size(141, 31);
            CreatedGameName.TabIndex = 4;
            CreatedGameName.Text = "Name";
            // 
            // AddGame
            // 
            AddGame.BackColor = Color.FromArgb(64, 0, 64);
            AddGame.ForeColor = SystemColors.ButtonFace;
            AddGame.Location = new Point(46, 320);
            AddGame.Margin = new Padding(4, 5, 4, 5);
            AddGame.Name = "AddGame";
            AddGame.Size = new Size(107, 38);
            AddGame.TabIndex = 5;
            AddGame.Text = "Add";
            AddGame.UseVisualStyleBackColor = false;
            AddGame.Click += AddGame_Click;
            // 
            // EditWorld
            // 
            EditWorld.BackColor = Color.Black;
            EditWorld.ForeColor = SystemColors.ButtonHighlight;
            EditWorld.Location = new Point(317, 387);
            EditWorld.Margin = new Padding(4, 5, 4, 5);
            EditWorld.Name = "EditWorld";
            EditWorld.Size = new Size(107, 38);
            EditWorld.TabIndex = 7;
            EditWorld.Text = "Edit World";
            EditWorld.UseVisualStyleBackColor = false;
            EditWorld.Click += EditWorld_Click;
            // 
            // EditFB
            // 
            EditFB.BackColor = Color.Black;
            EditFB.ForeColor = SystemColors.ButtonHighlight;
            EditFB.Location = new Point(450, 387);
            EditFB.Margin = new Padding(4, 5, 4, 5);
            EditFB.Name = "EditFB";
            EditFB.Size = new Size(151, 38);
            EditFB.TabIndex = 9;
            EditFB.Text = "Edit Final Boss";
            EditFB.UseVisualStyleBackColor = false;
            EditFB.Click += EditFB_Click;
            // 
            // EditEnemies
            // 
            EditEnemies.BackColor = Color.Black;
            EditEnemies.ForeColor = SystemColors.ButtonHighlight;
            EditEnemies.Location = new Point(627, 387);
            EditEnemies.Margin = new Padding(4, 5, 4, 5);
            EditEnemies.Name = "EditEnemies";
            EditEnemies.Size = new Size(149, 38);
            EditEnemies.TabIndex = 11;
            EditEnemies.Text = "Edit Enemies";
            EditEnemies.UseVisualStyleBackColor = false;
            EditEnemies.Click += EditEnemies_Click;
            // 
            // UpdateProperties
            // 
            UpdateProperties.BackColor = Color.Black;
            UpdateProperties.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateProperties.ForeColor = SystemColors.ButtonHighlight;
            UpdateProperties.Location = new Point(941, 193);
            UpdateProperties.Margin = new Padding(4, 5, 4, 5);
            UpdateProperties.Name = "UpdateProperties";
            UpdateProperties.Size = new Size(94, 48);
            UpdateProperties.TabIndex = 12;
            UpdateProperties.Text = "Update";
            UpdateProperties.UseVisualStyleBackColor = false;
            UpdateProperties.Click += UpdateProperties_Click;
            // 
            // SelectedProperties
            // 
            SelectedProperties.BackgroundColor = Color.FromArgb(64, 0, 64);
            SelectedProperties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SelectedProperties.Location = new Point(324, 252);
            SelectedProperties.Margin = new Padding(4, 5, 4, 5);
            SelectedProperties.Name = "SelectedProperties";
            SelectedProperties.RowHeadersWidth = 62;
            SelectedProperties.RowTemplate.Height = 25;
            SelectedProperties.Size = new Size(711, 125);
            SelectedProperties.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(324, 173);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(256, 38);
            label7.TabIndex = 14;
            label7.Text = "Selected Properties";
            // 
            // DelGame
            // 
            DelGame.BackColor = Color.FromArgb(64, 0, 64);
            DelGame.ForeColor = SystemColors.ButtonFace;
            DelGame.Location = new Point(47, 590);
            DelGame.Margin = new Padding(4, 5, 4, 5);
            DelGame.Name = "DelGame";
            DelGame.Size = new Size(107, 38);
            DelGame.TabIndex = 54;
            DelGame.Text = "Delete Enemies";
            DelGame.UseVisualStyleBackColor = false;
            DelGame.Click += DelGame_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.FromArgb(64, 0, 64);
            label16.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ButtonFace;
            label16.Location = new Point(47, 445);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(190, 38);
            label16.TabIndex = 53;
            label16.Text = "Delete Games";
            // 
            // NameDelGame
            // 
            NameDelGame.BackColor = Color.FromArgb(64, 0, 64);
            NameDelGame.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NameDelGame.ForeColor = SystemColors.ButtonFace;
            NameDelGame.Location = new Point(49, 523);
            NameDelGame.Margin = new Padding(4, 5, 4, 5);
            NameDelGame.Name = "NameDelGame";
            NameDelGame.Size = new Size(141, 31);
            NameDelGame.TabIndex = 52;
            NameDelGame.Text = "Name ";
            // 
            // UpdateGamesCreated
            // 
            UpdateGamesCreated.BackColor = Color.Black;
            UpdateGamesCreated.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateGamesCreated.ForeColor = SystemColors.ButtonHighlight;
            UpdateGamesCreated.Location = new Point(941, 465);
            UpdateGamesCreated.Margin = new Padding(4, 5, 4, 5);
            UpdateGamesCreated.Name = "UpdateGamesCreated";
            UpdateGamesCreated.Size = new Size(94, 48);
            UpdateGamesCreated.TabIndex = 55;
            UpdateGamesCreated.Text = "Update";
            UpdateGamesCreated.UseVisualStyleBackColor = false;
            UpdateGamesCreated.Click += UpdateGamesCreated_Click;
            // 
            // BackGame
            // 
            BackGame.BackColor = Color.Black;
            BackGame.ForeColor = SystemColors.ButtonHighlight;
            BackGame.Location = new Point(866, 875);
            BackGame.Margin = new Padding(4, 5, 4, 5);
            BackGame.Name = "BackGame";
            BackGame.Size = new Size(170, 53);
            BackGame.TabIndex = 75;
            BackGame.Text = "Back";
            BackGame.UseVisualStyleBackColor = false;
            BackGame.Click += BackGame_Click;
            // 
            // CreateGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(1053, 945);
            Controls.Add(BackGame);
            Controls.Add(UpdateGamesCreated);
            Controls.Add(DelGame);
            Controls.Add(label16);
            Controls.Add(NameDelGame);
            Controls.Add(label7);
            Controls.Add(SelectedProperties);
            Controls.Add(UpdateProperties);
            Controls.Add(EditEnemies);
            Controls.Add(EditFB);
            Controls.Add(EditWorld);
            Controls.Add(AddGame);
            Controls.Add(CreatedGameName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(GamesCreated);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CreateGame";
            Text = "CreateGame";
            Load += UpdateProperties_Click;
            ((System.ComponentModel.ISupportInitialize)GamesCreated).EndInit();
            ((System.ComponentModel.ISupportInitialize)SelectedProperties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView GamesCreated;
        private Label label2;
        private Label label3;
        private TextBox CreatedGameName;
        private Button AddGame;
        private Button EditWorld;
        private Button EditFB;
        private Button EditEnemies;
        private Button UpdateProperties;
        private DataGridView SelectedProperties;
        private Label label7;
        private Button DelGame;
        private Label label16;
        private TextBox NameDelGame;
        private Button UpdateGamesCreated;
        private Button BackGame;
    }
}