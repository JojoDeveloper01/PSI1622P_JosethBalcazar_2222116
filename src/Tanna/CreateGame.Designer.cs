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
            label4 = new Label();
            EditFB = new Button();
            label5 = new Label();
            EditEnemies = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)GamesCreated).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(119, 30);
            label1.Name = "label1";
            label1.Size = new Size(182, 37);
            label1.TabIndex = 0;
            label1.Text = "Create Game";
            // 
            // GamesCreated
            // 
            GamesCreated.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GamesCreated.Location = new Point(243, 131);
            GamesCreated.Name = "GamesCreated";
            GamesCreated.RowTemplate.Height = 25;
            GamesCreated.Size = new Size(343, 283);
            GamesCreated.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(243, 98);
            label2.Name = "label2";
            label2.Size = new Size(116, 21);
            label2.TabIndex = 2;
            label2.Text = "Games Created";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(45, 102);
            label3.Name = "label3";
            label3.Size = new Size(92, 17);
            label3.TabIndex = 3;
            label3.Text = "Create Game";
            // 
            // CreatedGameName
            // 
            CreatedGameName.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CreatedGameName.Location = new Point(45, 131);
            CreatedGameName.Name = "CreatedGameName";
            CreatedGameName.Size = new Size(100, 23);
            CreatedGameName.TabIndex = 4;
            CreatedGameName.Text = "Name";
            // 
            // AddGame
            // 
            AddGame.Location = new Point(45, 170);
            AddGame.Name = "AddGame";
            AddGame.Size = new Size(75, 23);
            AddGame.TabIndex = 5;
            AddGame.Text = "Add";
            AddGame.UseVisualStyleBackColor = true;
            AddGame.Click += AddGame_Click;
            // 
            // EditWorld
            // 
            EditWorld.Location = new Point(45, 249);
            EditWorld.Name = "EditWorld";
            EditWorld.Size = new Size(75, 23);
            EditWorld.TabIndex = 7;
            EditWorld.Text = "Edit";
            EditWorld.UseVisualStyleBackColor = true;
            EditWorld.Click += EditWorld_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(45, 220);
            label4.Name = "label4";
            label4.Size = new Size(119, 17);
            label4.TabIndex = 6;
            label4.Text = "Add/Delete World";
            // 
            // EditFB
            // 
            EditFB.Location = new Point(45, 320);
            EditFB.Name = "EditFB";
            EditFB.Size = new Size(75, 23);
            EditFB.TabIndex = 9;
            EditFB.Text = "Edit";
            EditFB.UseVisualStyleBackColor = true;
            EditFB.Click += EditFB_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(45, 291);
            label5.Name = "label5";
            label5.Size = new Size(147, 17);
            label5.TabIndex = 8;
            label5.Text = "Add/Delete Final Boss";
            // 
            // EditEnemies
            // 
            EditEnemies.Location = new Point(45, 391);
            EditEnemies.Name = "EditEnemies";
            EditEnemies.Size = new Size(75, 23);
            EditEnemies.TabIndex = 11;
            EditEnemies.Text = "Edit";
            EditEnemies.UseVisualStyleBackColor = true;
            EditEnemies.Click += EditEnemies_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(45, 362);
            label6.Name = "label6";
            label6.Size = new Size(136, 17);
            label6.TabIndex = 10;
            label6.Text = "Add/Delete Enemies";
            // 
            // CreateGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(631, 450);
            Controls.Add(EditEnemies);
            Controls.Add(label6);
            Controls.Add(EditFB);
            Controls.Add(label5);
            Controls.Add(EditWorld);
            Controls.Add(label4);
            Controls.Add(AddGame);
            Controls.Add(CreatedGameName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(GamesCreated);
            Controls.Add(label1);
            Name = "CreateGame";
            Text = "CreateGame";
            ((System.ComponentModel.ISupportInitialize)GamesCreated).EndInit();
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
        private Label label4;
        private Button EditFB;
        private Label label5;
        private Button EditEnemies;
        private Label label6;
    }
}