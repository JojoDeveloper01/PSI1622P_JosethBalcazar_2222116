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
            try_passwordRegister.BackColor = Color.FromArgb(64, 0, 64);
            try_passwordRegister.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            try_passwordRegister.ForeColor = Color.White;
            try_passwordRegister.Location = new Point(97, 328);
            try_passwordRegister.Margin = new Padding(4, 5, 4, 5);
            try_passwordRegister.Name = "try_passwordRegister";
            try_passwordRegister.Size = new Size(188, 31);
            try_passwordRegister.TabIndex = 10;
            try_passwordRegister.Text = "Confirm Password";
            // 
            // SignUp
            // 
            SignUp.BackColor = Color.Black;
            SignUp.ForeColor = SystemColors.ButtonFace;
            SignUp.Location = new Point(97, 400);
            SignUp.Margin = new Padding(4, 5, 4, 5);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(154, 48);
            SignUp.TabIndex = 9;
            SignUp.Text = "Sign Up";
            SignUp.UseVisualStyleBackColor = false;
            SignUp.Click += SignUp_Click;
            // 
            // passwordRegister
            // 
            passwordRegister.BackColor = Color.FromArgb(64, 0, 64);
            passwordRegister.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            passwordRegister.ForeColor = Color.White;
            passwordRegister.Location = new Point(97, 255);
            passwordRegister.Margin = new Padding(4, 5, 4, 5);
            passwordRegister.Name = "passwordRegister";
            passwordRegister.Size = new Size(188, 31);
            passwordRegister.TabIndex = 8;
            passwordRegister.Text = "Password";
            // 
            // usernameRegister
            // 
            usernameRegister.BackColor = Color.FromArgb(64, 0, 64);
            usernameRegister.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            usernameRegister.ForeColor = Color.White;
            usernameRegister.Location = new Point(97, 183);
            usernameRegister.Margin = new Padding(4, 5, 4, 5);
            usernameRegister.Name = "usernameRegister";
            usernameRegister.Size = new Size(188, 31);
            usernameRegister.TabIndex = 7;
            usernameRegister.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 0, 64);
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(97, 70);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(170, 54);
            label1.TabIndex = 20;
            label1.Text = "Sign Up";
            // 
            // Sign_up
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(400, 497);
            Controls.Add(label1);
            Controls.Add(try_passwordRegister);
            Controls.Add(SignUp);
            Controls.Add(passwordRegister);
            Controls.Add(usernameRegister);
            Margin = new Padding(4, 5, 4, 5);
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