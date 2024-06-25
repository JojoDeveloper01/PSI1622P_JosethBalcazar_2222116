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
            Username.Location = new Point(87, 121);
            Username.Name = "Username";
            Username.Size = new Size(153, 23);
            Username.TabIndex = 1;
            // 
            // Password
            // 
            Password.Location = new Point(87, 162);
            Password.Name = "Password";
            Password.Size = new Size(153, 23);
            Password.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 85);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 121);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 162);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(87, 27);
            label5.Name = "label5";
            label5.Size = new Size(122, 37);
            label5.TabIndex = 16;
            label5.Text = "Account";
            // 
            // Save
            // 
            Save.Location = new Point(87, 200);
            Save.Name = "Save";
            Save.Size = new Size(75, 23);
            Save.TabIndex = 17;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(87, 86);
            ID.Name = "ID";
            ID.Size = new Size(0, 15);
            ID.TabIndex = 18;
            // 
            // CreateGame
            // 
            CreateGame.Location = new Point(85, 290);
            CreateGame.Name = "CreateGame";
            CreateGame.Size = new Size(119, 28);
            CreateGame.TabIndex = 22;
            CreateGame.Text = "Create a Game";
            CreateGame.UseVisualStyleBackColor = true;
            CreateGame.Click += CreateGame_Click;
            // 
            // EditUsers
            // 
            EditUsers.Location = new Point(87, 256);
            EditUsers.Name = "EditUsers";
            EditUsers.Size = new Size(119, 28);
            EditUsers.TabIndex = 23;
            EditUsers.Text = "Edit Users";
            EditUsers.UseVisualStyleBackColor = true;
            EditUsers.Click += EditUsers_Click;
            // 
            // BackAccount
            // 
            BackAccount.Location = new Point(171, 364);
            BackAccount.Name = "BackAccount";
            BackAccount.Size = new Size(119, 32);
            BackAccount.TabIndex = 76;
            BackAccount.Text = "Back";
            BackAccount.UseVisualStyleBackColor = true;
            BackAccount.Click += BackAccount_Click;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(302, 408);
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