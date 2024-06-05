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
            ID = new TextBox();
            Username = new TextBox();
            Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Delete = new Button();
            UsernameDel = new TextBox();
            See_All_Users = new Button();
            SuspendLayout();
            // 
            // ID
            // 
            ID.Location = new Point(187, 156);
            ID.Name = "ID";
            ID.Size = new Size(153, 23);
            ID.TabIndex = 0;
            // 
            // Username
            // 
            Username.Location = new Point(187, 195);
            Username.Name = "Username";
            Username.Size = new Size(153, 23);
            Username.TabIndex = 1;
            // 
            // Password
            // 
            Password.Location = new Point(187, 236);
            Password.Name = "Password";
            Password.Size = new Size(153, 23);
            Password.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 159);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 195);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 236);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // Delete
            // 
            Delete.Location = new Point(404, 195);
            Delete.Name = "Delete";
            Delete.Size = new Size(108, 29);
            Delete.TabIndex = 13;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // UsernameDel
            // 
            UsernameDel.Location = new Point(404, 152);
            UsernameDel.Name = "UsernameDel";
            UsernameDel.Size = new Size(133, 23);
            UsernameDel.TabIndex = 12;
            // 
            // See_All_Users
            // 
            See_All_Users.Location = new Point(562, 150);
            See_All_Users.Name = "See_All_Users";
            See_All_Users.Size = new Size(115, 33);
            See_All_Users.TabIndex = 14;
            See_All_Users.Text = "See all users";
            See_All_Users.UseVisualStyleBackColor = true;
            See_All_Users.Click += See_All_Users_Click;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(See_All_Users);
            Controls.Add(Delete);
            Controls.Add(UsernameDel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(ID);
            Name = "Account";
            Text = "Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ID;
        private TextBox Username;
        private TextBox Password;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Delete;
        private TextBox UsernameDel;
        private Button See_All_Users;
    }
}