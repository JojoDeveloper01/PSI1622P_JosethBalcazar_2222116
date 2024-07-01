namespace Tanna
{
    partial class Account
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
            Username = new TextBox();
            Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            Save = new Button();
            ID = new Label();
            CreateGame = new Button();
            EditUsers = new Button();
            BackAccount = new Button();
            SuspendLayout();
            // 
            // Username
            // 
            Username.BackColor = Color.FromArgb(64, 0, 64);
            Username.ForeColor = SystemColors.Window;
            Username.Location = new Point(124, 202);
            Username.Margin = new Padding(4, 5, 4, 5);
            Username.Name = "Username";
            Username.Size = new Size(217, 31);
            Username.TabIndex = 1;
            // 
            // Password
            // 
            Password.BackColor = Color.FromArgb(64, 0, 64);
            Password.ForeColor = SystemColors.Window;
            Password.Location = new Point(124, 270);
            Password.Margin = new Padding(4, 5, 4, 5);
            Password.Name = "Password";
            Password.Size = new Size(217, 31);
            Password.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(86, 143);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(30, 202);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(34, 270);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(124, 45);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(177, 54);
            label5.TabIndex = 16;
            label5.Text = "Account";
            // 
            // Save
            // 
            Save.BackColor = Color.Black;
            Save.ForeColor = SystemColors.ButtonFace;
            Save.Location = new Point(124, 333);
            Save.Margin = new Padding(4, 5, 4, 5);
            Save.Name = "Save";
            Save.Size = new Size(107, 38);
            Save.TabIndex = 17;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.ForeColor = SystemColors.ControlLightLight;
            ID.Location = new Point(124, 143);
            ID.Margin = new Padding(4, 0, 4, 0);
            ID.Name = "ID";
            ID.Size = new Size(0, 25);
            ID.TabIndex = 18;
            // 
            // CreateGame
            // 
            CreateGame.BackColor = Color.Black;
            CreateGame.ForeColor = SystemColors.ButtonFace;
            CreateGame.Location = new Point(124, 484);
            CreateGame.Margin = new Padding(4, 5, 4, 5);
            CreateGame.Name = "CreateGame";
            CreateGame.Size = new Size(170, 47);
            CreateGame.TabIndex = 22;
            CreateGame.Text = "Create a Game";
            CreateGame.UseVisualStyleBackColor = false;
            CreateGame.Click += CreateGame_Click;
            // 
            // EditUsers
            // 
            EditUsers.BackColor = Color.Black;
            EditUsers.ForeColor = SystemColors.ButtonFace;
            EditUsers.Location = new Point(124, 427);
            EditUsers.Margin = new Padding(4, 5, 4, 5);
            EditUsers.Name = "EditUsers";
            EditUsers.Size = new Size(170, 47);
            EditUsers.TabIndex = 23;
            EditUsers.Text = "Edit Users";
            EditUsers.UseVisualStyleBackColor = false;
            EditUsers.Click += EditUsers_Click;
            // 
            // BackAccount
            // 
            BackAccount.BackColor = Color.Black;
            BackAccount.ForeColor = SystemColors.ButtonFace;
            BackAccount.Location = new Point(244, 607);
            BackAccount.Margin = new Padding(4, 5, 4, 5);
            BackAccount.Name = "BackAccount";
            BackAccount.Size = new Size(170, 53);
            BackAccount.TabIndex = 76;
            BackAccount.Text = "Back";
            BackAccount.UseVisualStyleBackColor = false;
            BackAccount.Click += BackAccount_Click;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(431, 680);
            Controls.Add(BackAccount);
            Controls.Add(EditUsers);
            Controls.Add(CreateGame);
            Controls.Add(ID);
            Controls.Add(Save);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Password);
            Controls.Add(Username);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Account";
            Text = "W";
            Load += Account_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Username;
        private TextBox Password;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Button Save;
        private Label ID;
        private Button CreateGame;
        private Button EditUsers;
        private Button BackAccount;
    }
}