namespace Tanna
{
    partial class Sign_in
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
            SignIn = new Button();
            passwordLogin = new TextBox();
            usernameLogin = new TextBox();
            SuspendLayout();
            // 
            // SignIn
            // 
            SignIn.Location = new Point(322, 241);
            SignIn.Name = "SignIn";
            SignIn.Size = new Size(108, 29);
            SignIn.TabIndex = 5;
            SignIn.Text = "Sign In";
            SignIn.UseVisualStyleBackColor = true;
            SignIn.Click += SignIn_Click;
            // 
            // passwordLogin
            // 
            passwordLogin.Location = new Point(322, 201);
            passwordLogin.Name = "passwordLogin";
            passwordLogin.Size = new Size(133, 23);
            passwordLogin.TabIndex = 4;
            // 
            // usernameLogin
            // 
            usernameLogin.Location = new Point(322, 158);
            usernameLogin.Name = "usernameLogin";
            usernameLogin.Size = new Size(133, 23);
            usernameLogin.TabIndex = 3;
            // 
            // Sign_in
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(SignIn);
            Controls.Add(passwordLogin);
            Controls.Add(usernameLogin);
            Name = "Sign_in";
            Text = "Sign_in";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SignIn;
        private TextBox passwordLogin;
        private TextBox usernameLogin;
    }
}