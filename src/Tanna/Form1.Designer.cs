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
            SuspendLayout();
            // 
            // SignUpButton
            // 
            SignUpButton.Location = new Point(808, 328);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(137, 41);
            SignUpButton.TabIndex = 12;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // SignInButton
            // 
            SignInButton.Location = new Point(808, 375);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(137, 36);
            SignInButton.TabIndex = 13;
            SignInButton.Text = "Sign In";
            SignInButton.UseVisualStyleBackColor = true;
            SignInButton.Click += SignInButton_Click;
            // 
            // Account
            // 
            Account.Location = new Point(808, 359);
            Account.Name = "Account";
            Account.Size = new Size(137, 52);
            Account.TabIndex = 14;
            Account.Text = "Account";
            Account.UseVisualStyleBackColor = true;
            Account.Click += Account_Click;
            // 
            // Logout
            // 
            Logout.Location = new Point(870, 337);
            Logout.Name = "Logout";
            Logout.Size = new Size(75, 23);
            Logout.TabIndex = 16;
            Logout.Text = "Logout";
            Logout.UseVisualStyleBackColor = true;
            Logout.Click += Logout_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(957, 423);
            Controls.Add(Logout);
            Controls.Add(Account);
            Controls.Add(SignInButton);
            Controls.Add(SignUpButton);
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
        }

        #endregion
        private Button SignUpButton;
        private Button SignInButton;
        private Button Account;
        private Button Logout;
    }
}