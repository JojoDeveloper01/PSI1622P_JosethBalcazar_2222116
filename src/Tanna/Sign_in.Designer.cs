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
            label1 = new Label();
            Sign_Up = new LinkLabel();
            Back = new Button();
            SuspendLayout();
            // 
            // SignIn
            // 
            SignIn.BackColor = Color.Black;
            SignIn.ForeColor = SystemColors.Control;
            SignIn.Location = new Point(102, 335);
            SignIn.Margin = new Padding(4, 5, 4, 5);
            SignIn.Name = "SignIn";
            SignIn.Size = new Size(154, 48);
            SignIn.TabIndex = 5;
            SignIn.Text = "Sign In";
            SignIn.UseVisualStyleBackColor = false;
            SignIn.Click += SignIn_Click;
            // 
            // passwordLogin
            // 
            passwordLogin.BackColor = Color.FromArgb(64, 0, 64);
            passwordLogin.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLogin.ForeColor = SystemColors.Window;
            passwordLogin.Location = new Point(103, 245);
            passwordLogin.Margin = new Padding(4, 5, 4, 5);
            passwordLogin.Name = "passwordLogin";
            passwordLogin.Size = new Size(188, 31);
            passwordLogin.TabIndex = 4;
            passwordLogin.Text = "Password";
            // 
            // usernameLogin
            // 
            usernameLogin.BackColor = Color.FromArgb(64, 0, 64);
            usernameLogin.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLogin.ForeColor = SystemColors.Window;
            usernameLogin.Location = new Point(103, 173);
            usernameLogin.Margin = new Padding(4, 5, 4, 5);
            usernameLogin.Name = "usernameLogin";
            usernameLogin.Size = new Size(188, 31);
            usernameLogin.TabIndex = 3;
            usernameLogin.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(103, 75);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(153, 54);
            label1.TabIndex = 20;
            label1.Text = "Sign In";
            // 
            // Sign_Up
            // 
            Sign_Up.AutoSize = true;
            Sign_Up.LinkColor = Color.Gainsboro;
            Sign_Up.Location = new Point(102, 292);
            Sign_Up.Name = "Sign_Up";
            Sign_Up.Size = new Size(75, 25);
            Sign_Up.TabIndex = 22;
            Sign_Up.TabStop = true;
            Sign_Up.Text = "Sign Up";
            Sign_Up.LinkClicked += Sign_Up_LinkClicked;
            // 
            // Back
            // 
            Back.BackColor = Color.Black;
            Back.ForeColor = SystemColors.ButtonHighlight;
            Back.Location = new Point(272, 422);
            Back.Margin = new Padding(4, 5, 4, 5);
            Back.Name = "Back";
            Back.Size = new Size(118, 39);
            Back.TabIndex = 77;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Sign_in
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(403, 475);
            Controls.Add(Back);
            Controls.Add(Sign_Up);
            Controls.Add(label1);
            Controls.Add(SignIn);
            Controls.Add(passwordLogin);
            Controls.Add(usernameLogin);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Sign_in";
            Text = "Sign_in";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SignIn;
        private TextBox passwordLogin;
        private TextBox usernameLogin;
        private Label label1;
        private LinkLabel Sign_Up;
        private Button Back;
    }
}