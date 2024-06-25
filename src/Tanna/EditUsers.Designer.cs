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
            Delete = new Button();
            UsernameDel = new TextBox();
            SeeAllUsers = new DataGridView();
            UpdateAllUsers = new Button();
            BackAdminSec = new Button();
            ((System.ComponentModel.ISupportInitialize)SeeAllUsers).BeginInit();
            SuspendLayout();
            // 
            // PasswordCreate
            // 
            PasswordCreate.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordCreate.Location = new Point(38, 153);
            PasswordCreate.Name = "PasswordCreate";
            PasswordCreate.Size = new Size(133, 23);
            PasswordCreate.TabIndex = 28;
            PasswordCreate.Text = "Password";
            // 
            // Create
            // 
            Create.Location = new Point(38, 182);
            Create.Name = "Create";
            Create.Size = new Size(108, 29);
            Create.TabIndex = 27;
            Create.Text = "Create User";
            Create.UseVisualStyleBackColor = true;
            Create.Click += Create_Click;
            // 
            // UserCreate
            // 
            UserCreate.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UserCreate.Location = new Point(38, 124);
            UserCreate.Name = "UserCreate";
            UserCreate.Size = new Size(133, 23);
            UserCreate.TabIndex = 26;
            UserCreate.Text = "Name";
            // 
            // AdminLabel
            // 
            AdminLabel.AutoSize = true;
            AdminLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            AdminLabel.Location = new Point(38, 47);
            AdminLabel.Name = "AdminLabel";
            AdminLabel.Size = new Size(204, 37);
            AdminLabel.TabIndex = 25;
            AdminLabel.Text = "Admin Section";
            // 
            // Delete
            // 
            Delete.Location = new Point(38, 277);
            Delete.Name = "Delete";
            Delete.Size = new Size(108, 29);
            Delete.TabIndex = 23;
            Delete.Text = "Delete User";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // UsernameDel
            // 
            UsernameDel.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameDel.Location = new Point(38, 241);
            UsernameDel.Name = "UsernameDel";
            UsernameDel.Size = new Size(133, 23);
            UsernameDel.TabIndex = 22;
            UsernameDel.Text = "Name";
            // 
            // SeeAllUsers
            // 
            SeeAllUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SeeAllUsers.Location = new Point(244, 124);
            SeeAllUsers.Name = "SeeAllUsers";
            SeeAllUsers.RowTemplate.Height = 25;
            SeeAllUsers.Size = new Size(435, 279);
            SeeAllUsers.TabIndex = 29;
            // 
            // UpdateAllUsers
            // 
            UpdateAllUsers.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateAllUsers.Location = new Point(613, 89);
            UpdateAllUsers.Name = "UpdateAllUsers";
            UpdateAllUsers.Size = new Size(66, 29);
            UpdateAllUsers.TabIndex = 30;
            UpdateAllUsers.Text = "Update";
            UpdateAllUsers.UseVisualStyleBackColor = true;
            UpdateAllUsers.Click += UpdateAllUsers_Click;
            // 
            // BackAdminSec
            // 
            BackAdminSec.Location = new Point(565, 422);
            BackAdminSec.Name = "BackAdminSec";
            BackAdminSec.Size = new Size(114, 32);
            BackAdminSec.TabIndex = 76;
            BackAdminSec.Text = "Back";
            BackAdminSec.UseVisualStyleBackColor = true;
            BackAdminSec.Click += BackAdminSec_Click;
            // 
            // EditUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(691, 466);
            Controls.Add(BackAdminSec);
            Controls.Add(UpdateAllUsers);
            Controls.Add(SeeAllUsers);
            Controls.Add(PasswordCreate);
            Controls.Add(Create);
            Controls.Add(UserCreate);
            Controls.Add(AdminLabel);
            Controls.Add(Delete);
            Controls.Add(UsernameDel);
            Name = "EditUsers";
            Text = "EditUsers";
            ((System.ComponentModel.ISupportInitialize)SeeAllUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PasswordCreate;
        private Button Create;
        private TextBox UserCreate;
        private Label AdminLabel;
        private Button Delete;
        private TextBox UsernameDel;
        private DataGridView SeeAllUsers;
        private Button UpdateAllUsers;
        private Button BackAdminSec;
    }
}