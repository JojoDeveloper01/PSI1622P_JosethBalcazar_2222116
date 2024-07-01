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
            Update = new Button();
            SuspendLayout();
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = Color.Black;
            SignUpButton.ForeColor = SystemColors.ButtonHighlight;
            SignUpButton.Location = new Point(927, 478);
            SignUpButton.Margin = new Padding(4, 5, 4, 5);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(196, 68);
            SignUpButton.TabIndex = 12;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // SignInButton
            // 
            SignInButton.BackColor = Color.Black;
            SignInButton.ForeColor = SystemColors.ButtonHighlight;
            SignInButton.Location = new Point(927, 557);
            SignInButton.Margin = new Padding(4, 5, 4, 5);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(196, 60);
            SignInButton.TabIndex = 13;
            SignInButton.Text = "Sign In";
            SignInButton.UseVisualStyleBackColor = false;
            SignInButton.Click += SignInButton_Click;
            // 
            // Account
            // 
            Account.BackColor = Color.Black;
            Account.ForeColor = SystemColors.ButtonHighlight;
            Account.Location = new Point(927, 528);
            Account.Margin = new Padding(4, 5, 4, 5);
            Account.Name = "Account";
            Account.Size = new Size(196, 87);
            Account.TabIndex = 14;
            Account.Text = "Account";
            Account.UseVisualStyleBackColor = false;
            Account.Click += Account_Click;
            // 
            // Logout
            // 
            Logout.BackColor = Color.Black;
            Logout.ForeColor = SystemColors.ButtonHighlight;
            Logout.Location = new Point(1016, 493);
            Logout.Margin = new Padding(4, 5, 4, 5);
            Logout.Name = "Logout";
            Logout.Size = new Size(107, 38);
            Logout.TabIndex = 16;
            Logout.Text = "Logout";
            Logout.UseVisualStyleBackColor = false;
            Logout.Click += Logout_Click;
            // 
            // Play
            // 
            Play.BackColor = Color.Black;
            Play.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Play.ForeColor = SystemColors.ButtonHighlight;
            Play.Location = new Point(73, 252);
            Play.Margin = new Padding(4, 5, 4, 5);
            Play.Name = "Play";
            Play.Size = new Size(317, 82);
            Play.TabIndex = 17;
            Play.Text = "Choose Game";
            Play.UseVisualStyleBackColor = false;
            Play.Click += Play_Click;
            // 
            // Exit
            // 
            Exit.BackColor = Color.Black;
            Exit.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Exit.ForeColor = SystemColors.Control;
            Exit.ImageAlign = ContentAlignment.MiddleLeft;
            Exit.Location = new Point(73, 522);
            Exit.Margin = new Padding(4, 5, 4, 5);
            Exit.Name = "Exit";
            Exit.Size = new Size(317, 82);
            Exit.TabIndex = 18;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(73, 105);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(455, 67);
            label1.TabIndex = 19;
            label1.Text = "Minigame Creator";
            // 
            // CreateGame
            // 
            CreateGame.BackColor = Color.Black;
            CreateGame.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CreateGame.ForeColor = Color.White;
            CreateGame.Location = new Point(73, 392);
            CreateGame.Margin = new Padding(4, 5, 4, 5);
            CreateGame.Name = "CreateGame";
            CreateGame.Size = new Size(317, 82);
            CreateGame.TabIndex = 20;
            CreateGame.Text = "Create Game";
            CreateGame.UseVisualStyleBackColor = false;
            CreateGame.Click += CreateGame_Click;
            // 
            // Update
            // 
            Update.BackColor = Color.Black;
            Update.ForeColor = SystemColors.ControlLightLight;
            Update.Location = new Point(1016, 20);
            Update.Margin = new Padding(4, 5, 4, 5);
            Update.Name = "Update";
            Update.Size = new Size(107, 38);
            Update.TabIndex = 21;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(1140, 637);
            Controls.Add(Update);
            Controls.Add(CreateGame);
            Controls.Add(label1);
            Controls.Add(Exit);
            Controls.Add(Play);
            Controls.Add(Logout);
            Controls.Add(Account);
            Controls.Add(SignInButton);
            Controls.Add(SignUpButton);
            Cursor = Cursors.Cross;
            Margin = new Padding(4, 5, 4, 5);
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
        private Button Update;
    }
}