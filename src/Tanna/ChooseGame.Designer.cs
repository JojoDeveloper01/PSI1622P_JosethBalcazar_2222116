namespace Tanna
{
    partial class ChooseGame
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
            BackChooseGame = new Button();
            GamesCreated = new DataGridView();
            Play = new Button();
            CreateGame = new Button();
            Update = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)GamesCreated).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(40, 65);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(313, 54);
            label1.TabIndex = 0;
            label1.Text = "Choose a Game";
            // 
            // BackChooseGame
            // 
            BackChooseGame.BackColor = Color.Black;
            BackChooseGame.ForeColor = SystemColors.ButtonHighlight;
            BackChooseGame.Location = new Point(970, 750);
            BackChooseGame.Margin = new Padding(4, 5, 4, 5);
            BackChooseGame.Name = "BackChooseGame";
            BackChooseGame.Size = new Size(170, 53);
            BackChooseGame.TabIndex = 77;
            BackChooseGame.Text = "Back";
            BackChooseGame.UseVisualStyleBackColor = false;
            BackChooseGame.Click += BackChooseGame_Click;
            // 
            // GamesCreated
            // 
            GamesCreated.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            GamesCreated.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            GamesCreated.BackgroundColor = Color.FromArgb(64, 0, 64);
            GamesCreated.ColumnHeadersHeight = 34;
            GamesCreated.Location = new Point(40, 260);
            GamesCreated.Margin = new Padding(4, 5, 4, 5);
            GamesCreated.Name = "GamesCreated";
            GamesCreated.RowHeadersWidth = 62;
            GamesCreated.RowTemplate.Height = 25;
            GamesCreated.Size = new Size(797, 543);
            GamesCreated.TabIndex = 78;
            // 
            // Play
            // 
            Play.BackColor = Color.Black;
            Play.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Play.ForeColor = SystemColors.ButtonHighlight;
            Play.Location = new Point(883, 260);
            Play.Margin = new Padding(4, 5, 4, 5);
            Play.Name = "Play";
            Play.Size = new Size(257, 82);
            Play.TabIndex = 79;
            Play.Text = "Play";
            Play.UseVisualStyleBackColor = false;
            Play.Click += Play_Click;
            // 
            // CreateGame
            // 
            CreateGame.BackColor = Color.Black;
            CreateGame.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CreateGame.ForeColor = SystemColors.ButtonHighlight;
            CreateGame.Location = new Point(883, 373);
            CreateGame.Margin = new Padding(4, 5, 4, 5);
            CreateGame.Name = "CreateGame";
            CreateGame.Size = new Size(257, 82);
            CreateGame.TabIndex = 80;
            CreateGame.Text = "Edit Game";
            CreateGame.UseVisualStyleBackColor = false;
            CreateGame.Click += CreateGame_Click;
            // 
            // Update
            // 
            Update.BackColor = Color.Black;
            Update.ForeColor = SystemColors.ButtonHighlight;
            Update.Location = new Point(1033, 20);
            Update.Margin = new Padding(4, 5, 4, 5);
            Update.Name = "Update";
            Update.Size = new Size(107, 38);
            Update.TabIndex = 81;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(40, 148);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(563, 38);
            label2.TabIndex = 82;
            label2.Text = "Select the line of the game you want to play";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(54, 202);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(41, 48);
            label3.TabIndex = 83;
            label3.Text = "⬇️";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.UseMnemonic = false;
            // 
            // ChooseGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(1156, 823);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Update);
            Controls.Add(CreateGame);
            Controls.Add(Play);
            Controls.Add(GamesCreated);
            Controls.Add(BackChooseGame);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ChooseGame";
            Text = "ChooseGame";
            ((System.ComponentModel.ISupportInitialize)GamesCreated).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BackChooseGame;
        private DataGridView GamesCreated;
        private Button Play;
        private Button CreateGame;
        private Button Update;
        private Label label2;
        private Label label3;
    }
}