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
            label1.Location = new Point(28, 39);
            label1.Name = "label1";
            label1.Size = new Size(214, 37);
            label1.TabIndex = 0;
            label1.Text = "Choose a Game";
            // 
            // BackChooseGame
            // 
            BackChooseGame.Location = new Point(679, 450);
            BackChooseGame.Name = "BackChooseGame";
            BackChooseGame.Size = new Size(119, 32);
            BackChooseGame.TabIndex = 77;
            BackChooseGame.Text = "Back";
            BackChooseGame.UseVisualStyleBackColor = true;
            BackChooseGame.Click += BackChooseGame_Click;
            // 
            // GamesCreated
            // 
            GamesCreated.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            GamesCreated.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            GamesCreated.Location = new Point(28, 156);
            GamesCreated.Name = "GamesCreated";
            GamesCreated.RowTemplate.Height = 25;
            GamesCreated.Size = new Size(558, 326);
            GamesCreated.TabIndex = 78;
            // 
            // Play
            // 
            Play.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Play.Location = new Point(618, 156);
            Play.Name = "Play";
            Play.Size = new Size(180, 49);
            Play.TabIndex = 79;
            Play.Text = "Play";
            Play.UseVisualStyleBackColor = true;
            Play.Click += Play_Click;
            // 
            // CreateGame
            // 
            CreateGame.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CreateGame.Location = new Point(618, 224);
            CreateGame.Name = "CreateGame";
            CreateGame.Size = new Size(180, 49);
            CreateGame.TabIndex = 80;
            CreateGame.Text = "Edit Game";
            CreateGame.UseVisualStyleBackColor = true;
            CreateGame.Click += CreateGame_Click;
            // 
            // Update
            // 
            Update.Location = new Point(723, 12);
            Update.Name = "Update";
            Update.Size = new Size(75, 23);
            Update.TabIndex = 81;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 89);
            label2.Name = "label2";
            label2.Size = new Size(380, 25);
            label2.TabIndex = 82;
            label2.Text = "Select the line of the game you want to play";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(38, 121);
            label3.Name = "label3";
            label3.Size = new Size(28, 32);
            label3.TabIndex = 83;
            label3.Text = "⬇️";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.UseMnemonic = false;
            // 
            // ChooseGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(809, 494);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Update);
            Controls.Add(CreateGame);
            Controls.Add(Play);
            Controls.Add(GamesCreated);
            Controls.Add(BackChooseGame);
            Controls.Add(label1);
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