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
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 35);
            label1.Name = "label1";
            label1.Size = new Size(182, 37);
            label1.TabIndex = 0;
            label1.Text = "Create Game";
            // 
            // GamesCreated
            // 
            GamesCreated.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GamesCreated.Location = new Point(227, 314);
            GamesCreated.Name = "GamesCreated";
            GamesCreated.RowTemplate.Height = 25;
            GamesCreated.Size = new Size(498, 181);
            GamesCreated.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(227, 269);
            label2.Name = "label2";
            label2.Size = new Size(140, 25);
            label2.TabIndex = 2;
            label2.Text = "Games Created";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 104);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 3;
            label3.Text = "Create Game";
            // 
            // CreatedGameName
            // 
            CreatedGameName.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CreatedGameName.Location = new Point(34, 151);
            CreatedGameName.Name = "CreatedGameName";
            CreatedGameName.Size = new Size(100, 23);
            CreatedGameName.TabIndex = 4;
            CreatedGameName.Text = "Name";
            // 
            // AddGame
            // 
            AddGame.Location = new Point(32, 192);
            AddGame.Name = "AddGame";
            AddGame.Size = new Size(75, 23);
            AddGame.TabIndex = 5;
            AddGame.Text = "Add";
            AddGame.UseVisualStyleBackColor = true;
            AddGame.Click += AddGame_Click;
            // 
            // EditWorld
            // 
            EditWorld.Location = new Point(227, 224);
            EditWorld.Name = "EditWorld";
            EditWorld.Size = new Size(75, 23);
            EditWorld.TabIndex = 7;
            EditWorld.Text = "Edit World";
            EditWorld.UseVisualStyleBackColor = true;
            EditWorld.Click += EditWorld_Click;
            // 
            // EditFB
            // 
            EditFB.Location = new Point(318, 224);
            EditFB.Name = "EditFB";
            EditFB.Size = new Size(106, 23);
            EditFB.TabIndex = 9;
            EditFB.Text = "Final Boss Edit";
            EditFB.UseVisualStyleBackColor = true;
            EditFB.Click += EditFB_Click;
            // 
            // EditEnemies
            // 
            EditEnemies.Location = new Point(442, 224);
            EditEnemies.Name = "EditEnemies";
            EditEnemies.Size = new Size(104, 23);
            EditEnemies.TabIndex = 11;
            EditEnemies.Text = " Edit Enemies";
            EditEnemies.UseVisualStyleBackColor = true;
            EditEnemies.Click += EditEnemies_Click;
            // 
            // UpdateProperties
            // 
            UpdateProperties.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateProperties.Location = new Point(659, 116);
            UpdateProperties.Name = "UpdateProperties";
            UpdateProperties.Size = new Size(66, 29);
            UpdateProperties.TabIndex = 12;
            UpdateProperties.Text = "Update";
            UpdateProperties.UseVisualStyleBackColor = true;
            UpdateProperties.Click += UpdateProperties_Click;
            // 
            // SelectedProperties
            // 
            SelectedProperties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SelectedProperties.Location = new Point(227, 151);
            SelectedProperties.Name = "SelectedProperties";
            SelectedProperties.RowTemplate.Height = 25;
            SelectedProperties.Size = new Size(498, 64);
            SelectedProperties.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(227, 104);
            label7.Name = "label7";
            label7.Size = new Size(174, 25);
            label7.TabIndex = 14;
            label7.Text = "Selected Properties";
            // 
            // DelGame
            // 
            DelGame.Location = new Point(33, 354);
            DelGame.Name = "DelGame";
            DelGame.Size = new Size(75, 23);
            DelGame.TabIndex = 54;
            DelGame.Text = "Delete Enemies";
            DelGame.UseVisualStyleBackColor = true;
            DelGame.Click += DelGame_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(33, 267);
            label16.Name = "label16";
            label16.Size = new Size(128, 25);
            label16.TabIndex = 53;
            label16.Text = "Delete Games";
            // 
            // NameDelGame
            // 
            NameDelGame.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NameDelGame.Location = new Point(34, 314);
            NameDelGame.Name = "NameDelGame";
            NameDelGame.Size = new Size(100, 23);
            NameDelGame.TabIndex = 52;
            NameDelGame.Text = "Name ";
            // 
            // UpdateGamesCreated
            // 
            UpdateGamesCreated.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateGamesCreated.Location = new Point(659, 279);
            UpdateGamesCreated.Name = "UpdateGamesCreated";
            UpdateGamesCreated.Size = new Size(66, 29);
            UpdateGamesCreated.TabIndex = 55;
            UpdateGamesCreated.Text = "Update";
            UpdateGamesCreated.UseVisualStyleBackColor = true;
            UpdateGamesCreated.Click += UpdateGamesCreated_Click;
            // 
            // BackGame
            // 
            BackGame.Location = new Point(606, 525);
            BackGame.Name = "BackGame";
            BackGame.Size = new Size(119, 32);
            BackGame.TabIndex = 75;
            BackGame.Text = "Back";
            BackGame.UseVisualStyleBackColor = true;
            BackGame.Click += BackGame_Click;
            // 
            // CreateGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(737, 567);
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