namespace Tanna
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SignUpButton = new Button();
            SignInButton = new Button();
            Account = new Button();
            Logout = new Button();
            Play = new Button();
            Exit = new Button();
            label1 = new Label();
            CreateGame = new Button();
            SuspendLayout();
            // 
            // SignUpButton
            // 
            SignUpButton.Location = new Point(649, 287);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(137, 41);
            SignUpButton.TabIndex = 12;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // SignInButton
            // 
            SignInButton.Location = new Point(649, 334);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(137, 36);
            SignInButton.TabIndex = 13;
            SignInButton.Text = "Sign In";
            SignInButton.UseVisualStyleBackColor = true;
            SignInButton.Click += SignInButton_Click;
            // 
            // Account
            // 
            Account.Location = new Point(649, 318);
            Account.Name = "Account";
            Account.Size = new Size(137, 52);
            Account.TabIndex = 14;
            Account.Text = "Account";
            Account.UseVisualStyleBackColor = true;
            Account.Click += Account_Click;
            // 
            // Logout
            // 
            Logout.Location = new Point(711, 296);
            Logout.Name = "Logout";
            Logout.Size = new Size(75, 23);
            Logout.TabIndex = 16;
            Logout.Text = "Logout";
            Logout.UseVisualStyleBackColor = true;
            Logout.Click += Logout_Click;
            // 
            // Play
            // 
            Play.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Play.Location = new Point(51, 151);
            Play.Name = "Play";
            Play.Size = new Size(180, 49);
            Play.TabIndex = 17;
            Play.Text = "Play";
            Play.UseVisualStyleBackColor = true;
            Play.Click += Play_Click;
            // 
            // Exit
            // 
            Exit.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Exit.Location = new Point(51, 313);
            Exit.Name = "Exit";
            Exit.Size = new Size(180, 49);
            Exit.TabIndex = 18;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 63);
            label1.Name = "label1";
            label1.Size = new Size(251, 37);
            label1.TabIndex = 19;
            label1.Text = "Minigame Creator";
            // 
            // CreateGame
            // 
            CreateGame.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CreateGame.Location = new Point(51, 235);
            CreateGame.Name = "CreateGame";
            CreateGame.Size = new Size(180, 49);
            CreateGame.TabIndex = 20;
            CreateGame.Text = "Create Game";
            CreateGame.UseVisualStyleBackColor = true;
            CreateGame.Click += CreateGame_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(798, 382);
            Controls.Add(CreateGame);
            Controls.Add(label1);
            Controls.Add(Exit);
            Controls.Add(Play);
            Controls.Add(Logout);
            Controls.Add(Account);
            Controls.Add(SignInButton);
            Controls.Add(SignUpButton);
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SignUpButton;
        private Button SignInButton;
        private Button Account;
        private Button Logout;
        private Button Play;
        private Button Exit;
        private Label label1;
        private Button CreateGame;
    }
}