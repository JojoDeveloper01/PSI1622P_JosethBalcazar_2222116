namespace Tanna
{
    partial class Form1
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
            username = new TextBox();
            password = new TextBox();
            Sing_In = new Button();
            Sing_Up = new Button();
            passwordRegister = new TextBox();
            usernameRegister = new TextBox();
            try_passwordRegister = new TextBox();
            SuspendLayout();
            // 
            // username
            // 
            username.Location = new Point(503, 268);
            username.Name = "username";
            username.Size = new Size(133, 23);
            username.TabIndex = 0;
            // 
            // password
            // 
            password.Location = new Point(503, 311);
            password.Name = "password";
            password.Size = new Size(133, 23);
            password.TabIndex = 1;
            // 
            // Sing_In
            // 
            Sing_In.Location = new Point(503, 355);
            Sing_In.Name = "Sing_In";
            Sing_In.Size = new Size(108, 29);
            Sing_In.TabIndex = 2;
            Sing_In.Text = "Sing In";
            Sing_In.UseVisualStyleBackColor = true;
            Sing_In.Click += Sing_In_Click;
            // 
            // Sing_Up
            // 
            Sing_Up.Location = new Point(710, 398);
            Sing_Up.Name = "Sing_Up";
            Sing_Up.Size = new Size(108, 29);
            Sing_Up.TabIndex = 5;
            Sing_Up.Text = "Sing Up";
            Sing_Up.UseVisualStyleBackColor = true;
            Sing_Up.Click += Sing_Up_Click;
            // 
            // passwordRegister
            // 
            passwordRegister.Location = new Point(710, 311);
            passwordRegister.Name = "passwordRegister";
            passwordRegister.Size = new Size(133, 23);
            passwordRegister.TabIndex = 4;
            // 
            // usernameRegister
            // 
            usernameRegister.Location = new Point(710, 268);
            usernameRegister.Name = "usernameRegister";
            usernameRegister.Size = new Size(133, 23);
            usernameRegister.TabIndex = 3;
            // 
            // try_passwordRegister
            // 
            try_passwordRegister.Location = new Point(710, 355);
            try_passwordRegister.Name = "try_passwordRegister";
            try_passwordRegister.Size = new Size(133, 23);
            try_passwordRegister.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(1171, 663);
            Controls.Add(try_passwordRegister);
            Controls.Add(Sing_Up);
            Controls.Add(passwordRegister);
            Controls.Add(usernameRegister);
            Controls.Add(Sing_In);
            Controls.Add(password);
            Controls.Add(username);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private TextBox password;
        private Button Sing_In;
        private Button Sing_Up;
        private TextBox passwordRegister;
        private TextBox usernameRegister;
        private TextBox try_passwordRegister;
    }
}