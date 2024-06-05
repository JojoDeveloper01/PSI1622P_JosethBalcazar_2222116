namespace Tanna
{
    partial class Sign_up
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
            try_passwordRegister = new TextBox();
            SignUp = new Button();
            passwordRegister = new TextBox();
            usernameRegister = new TextBox();
            SuspendLayout();
            // 
            // try_passwordRegister
            // 
            try_passwordRegister.Location = new Point(320, 222);
            try_passwordRegister.Name = "try_passwordRegister";
            try_passwordRegister.Size = new Size(133, 23);
            try_passwordRegister.TabIndex = 10;
            // 
            // SignUp
            // 
            SignUp.Location = new Point(320, 265);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(108, 29);
            SignUp.TabIndex = 9;
            SignUp.Text = "Sign Up";
            SignUp.UseVisualStyleBackColor = true;
            SignUp.Click += SignUp_Click;
            // 
            // passwordRegister
            // 
            passwordRegister.Location = new Point(320, 178);
            passwordRegister.Name = "passwordRegister";
            passwordRegister.Size = new Size(133, 23);
            passwordRegister.TabIndex = 8;
            // 
            // usernameRegister
            // 
            usernameRegister.Location = new Point(320, 135);
            usernameRegister.Name = "usernameRegister";
            usernameRegister.Size = new Size(133, 23);
            usernameRegister.TabIndex = 7;
            // 
            // sing_up
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(try_passwordRegister);
            Controls.Add(SignUp);
            Controls.Add(passwordRegister);
            Controls.Add(usernameRegister);
            Name = "sing_up";
            Text = "sing_up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox try_passwordRegister;
        private Button SignUp;
        private TextBox passwordRegister;
        private TextBox usernameRegister;
    }
}