namespace Tanna
{
    partial class EditUsers
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
            PasswordCreate = new TextBox();
            Create = new Button();
            UserCreate = new TextBox();
            AdminLabel = new Label();
            See_All_Users = new Button();
            Delete = new Button();
            UsernameDel = new TextBox();
            SuspendLayout();
            // 
            // PasswordCreate
            // 
            PasswordCreate.Location = new Point(281, 142);
            PasswordCreate.Name = "PasswordCreate";
            PasswordCreate.Size = new Size(133, 23);
            PasswordCreate.TabIndex = 28;
            // 
            // Create
            // 
            Create.Location = new Point(281, 171);
            Create.Name = "Create";
            Create.Size = new Size(108, 29);
            Create.TabIndex = 27;
            Create.Text = "Create User";
            Create.UseVisualStyleBackColor = true;
            // 
            // UserCreate
            // 
            UserCreate.Location = new Point(281, 113);
            UserCreate.Name = "UserCreate";
            UserCreate.Size = new Size(133, 23);
            UserCreate.TabIndex = 26;
            // 
            // AdminLabel
            // 
            AdminLabel.AutoSize = true;
            AdminLabel.Location = new Point(216, 77);
            AdminLabel.Name = "AdminLabel";
            AdminLabel.Size = new Size(85, 15);
            AdminLabel.TabIndex = 25;
            AdminLabel.Text = "Admin Section";
            // 
            // See_All_Users
            // 
            See_All_Users.Location = new Point(196, 243);
            See_All_Users.Name = "See_All_Users";
            See_All_Users.Size = new Size(115, 33);
            See_All_Users.TabIndex = 24;
            See_All_Users.Text = "See all users";
            See_All_Users.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            Delete.Location = new Point(109, 147);
            Delete.Name = "Delete";
            Delete.Size = new Size(108, 29);
            Delete.TabIndex = 23;
            Delete.Text = "Delete User";
            Delete.UseVisualStyleBackColor = true;
            // 
            // UsernameDel
            // 
            UsernameDel.Location = new Point(109, 115);
            UsernameDel.Name = "UsernameDel";
            UsernameDel.Size = new Size(133, 23);
            UsernameDel.TabIndex = 22;
            // 
            // EditUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(532, 337);
            Controls.Add(PasswordCreate);
            Controls.Add(Create);
            Controls.Add(UserCreate);
            Controls.Add(AdminLabel);
            Controls.Add(See_All_Users);
            Controls.Add(Delete);
            Controls.Add(UsernameDel);
            Name = "EditUsers";
            Text = "EditUsers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PasswordCreate;
        private Button Create;
        private TextBox UserCreate;
        private Label AdminLabel;
        private Button See_All_Users;
        private Button Delete;
        private TextBox UsernameDel;
    }
}