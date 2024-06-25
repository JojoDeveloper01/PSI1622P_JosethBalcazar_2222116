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
            label1 = new Label();
            SuspendLayout();
            // 
            // try_passwordRegister
            // 
            try_passwordRegister.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            try_passwordRegister.Location = new Point(68, 197);
            try_passwordRegister.Name = "try_passwordRegister";
            try_passwordRegister.Size = new Size(133, 23);
            try_passwordRegister.TabIndex = 10;
            try_passwordRegister.Text = "Confirm Password";
            // 
            // SignUp
            // 
            SignUp.Location = new Point(68, 240);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(108, 29);
            SignUp.TabIndex = 9;
            SignUp.Text = "Sign Up";
            SignUp.UseVisualStyleBackColor = true;
            SignUp.Click += SignUp_Click;
            // 
            // passwordRegister
            // 
            passwordRegister.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            passwordRegister.Location = new Point(68, 153);
            passwordRegister.Name = "passwordRegister";
            passwordRegister.Size = new Size(133, 23);
            passwordRegister.TabIndex = 8;
            passwordRegister.Text = "Password";
            // 
            // usernameRegister
            // 
            usernameRegister.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            usernameRegister.Location = new Point(68, 110);
            usernameRegister.Name = "usernameRegister";
            usernameRegister.Size = new Size(133, 23);
            usernameRegister.TabIndex = 7;
            usernameRegister.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(68, 42);
            label1.Name = "label1";
            label1.Size = new Size(117, 37);
            label1.TabIndex = 20;
            label1.Text = "Sign Up";
            // 
            // Sign_up
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(280, 298);
            Controls.Add(label1);
            Controls.Add(try_passwordRegister);
            Controls.Add(SignUp);
            Controls.Add(passwordRegister);
            Controls.Add(usernameRegister);
            Name = "Sign_up";
            Text = "sing_up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox try_passwordRegister;
        private Button SignUp;
        private TextBox passwordRegister;
        private TextBox usernameRegister;
        private Label label1;
    }
}