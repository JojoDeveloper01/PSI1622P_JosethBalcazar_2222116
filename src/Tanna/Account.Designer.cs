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
            Username = new TextBox();
            Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Delete = new Button();
            UsernameDel = new TextBox();
            See_All_Users = new Button();
            AdminLabel = new Label();
            label5 = new Label();
            Save = new Button();
            ID = new Label();
            Create = new Button();
            UserCreate = new TextBox();
            PasswordCreate = new TextBox();
            SuspendLayout();
            // 
            // Username
            // 
            Username.Location = new Point(131, 126);
            Username.Name = "Username";
            Username.Size = new Size(153, 23);
            Username.TabIndex = 1;
            // 
            // Password
            // 
            Password.Location = new Point(131, 167);
            Password.Name = "Password";
            Password.Size = new Size(153, 23);
            Password.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 90);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 126);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 167);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // Delete
            // 
            Delete.Location = new Point(349, 160);
            Delete.Name = "Delete";
            Delete.Size = new Size(108, 29);
            Delete.TabIndex = 13;
            Delete.Text = "Delete User";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // UsernameDel
            // 
            UsernameDel.Location = new Point(349, 128);
            UsernameDel.Name = "UsernameDel";
            UsernameDel.Size = new Size(133, 23);
            UsernameDel.TabIndex = 12;
            // 
            // See_All_Users
            // 
            See_All_Users.Location = new Point(299, 258);
            See_All_Users.Name = "See_All_Users";
            See_All_Users.Size = new Size(115, 33);
            See_All_Users.TabIndex = 14;
            See_All_Users.Text = "See all users";
            See_All_Users.UseVisualStyleBackColor = true;
            See_All_Users.Click += See_All_Users_Click;
            // 
            // AdminLabel
            // 
            AdminLabel.AutoSize = true;
            AdminLabel.Location = new Point(456, 90);
            AdminLabel.Name = "AdminLabel";
            AdminLabel.Size = new Size(85, 15);
            AdminLabel.TabIndex = 15;
            AdminLabel.Text = "Admin Section";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(299, 21);
            label5.Name = "label5";
            label5.Size = new Size(90, 30);
            label5.TabIndex = 16;
            label5.Text = "Account";
            // 
            // Save
            // 
            Save.Location = new Point(131, 196);
            Save.Name = "Save";
            Save.Size = new Size(75, 23);
            Save.TabIndex = 17;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(131, 91);
            ID.Name = "ID";
            ID.Size = new Size(0, 15);
            ID.TabIndex = 18;
            // 
            // Create
            // 
            Create.Location = new Point(521, 184);
            Create.Name = "Create";
            Create.Size = new Size(108, 29);
            Create.TabIndex = 20;
            Create.Text = "Create User";
            Create.UseVisualStyleBackColor = true;
            // 
            // UserCreate
            // 
            UserCreate.Location = new Point(521, 126);
            UserCreate.Name = "UserCreate";
            UserCreate.Size = new Size(133, 23);
            UserCreate.TabIndex = 19;
            // 
            // PasswordCreate
            // 
            PasswordCreate.Location = new Point(521, 155);
            PasswordCreate.Name = "PasswordCreate";
            PasswordCreate.Size = new Size(133, 23);
            PasswordCreate.TabIndex = 21;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(700, 303);
            Controls.Add(PasswordCreate);
            Controls.Add(Create);
            Controls.Add(UserCreate);
            Controls.Add(ID);
            Controls.Add(Save);
            Controls.Add(label5);
            Controls.Add(AdminLabel);
            Controls.Add(See_All_Users);
            Controls.Add(Delete);
            Controls.Add(UsernameDel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Password);
            Controls.Add(Username);
            Name = "Account";
            Text = "Account";
            Load += Account_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Username;
        private TextBox Password;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Delete;
        private TextBox UsernameDel;
        private Button See_All_Users;
        private Label AdminLabel;
        private Label label5;
        private Button Save;
        private Label ID;
        private Button Create;
        private TextBox UserCreate;
        private TextBox PasswordCreate;
    }
}