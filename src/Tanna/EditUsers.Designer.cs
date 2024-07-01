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
            PasswordCreate.BackColor = Color.FromArgb(64, 0, 64);
            PasswordCreate.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordCreate.ForeColor = SystemColors.ButtonFace;
            PasswordCreate.Location = new Point(54, 255);
            PasswordCreate.Margin = new Padding(4, 5, 4, 5);
            PasswordCreate.Name = "PasswordCreate";
            PasswordCreate.Size = new Size(188, 31);
            PasswordCreate.TabIndex = 28;
            PasswordCreate.Text = "Password";
            // 
            // Create
            // 
            Create.BackColor = Color.Black;
            Create.ForeColor = SystemColors.ControlLightLight;
            Create.Location = new Point(54, 303);
            Create.Margin = new Padding(4, 5, 4, 5);
            Create.Name = "Create";
            Create.Size = new Size(154, 48);
            Create.TabIndex = 27;
            Create.Text = "Create User";
            Create.UseVisualStyleBackColor = false;
            Create.Click += Create_Click;
            // 
            // UserCreate
            // 
            UserCreate.BackColor = Color.FromArgb(64, 0, 64);
            UserCreate.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UserCreate.ForeColor = SystemColors.ButtonFace;
            UserCreate.Location = new Point(54, 207);
            UserCreate.Margin = new Padding(4, 5, 4, 5);
            UserCreate.Name = "UserCreate";
            UserCreate.Size = new Size(188, 31);
            UserCreate.TabIndex = 26;
            UserCreate.Text = "Name";
            // 
            // AdminLabel
            // 
            AdminLabel.AutoSize = true;
            AdminLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            AdminLabel.ForeColor = Color.White;
            AdminLabel.Location = new Point(54, 78);
            AdminLabel.Margin = new Padding(4, 0, 4, 0);
            AdminLabel.Name = "AdminLabel";
            AdminLabel.Size = new Size(297, 54);
            AdminLabel.TabIndex = 25;
            AdminLabel.Text = "Admin Section";
            // 
            // Delete
            // 
            Delete.BackColor = Color.Black;
            Delete.ForeColor = SystemColors.ControlLightLight;
            Delete.Location = new Point(54, 462);
            Delete.Margin = new Padding(4, 5, 4, 5);
            Delete.Name = "Delete";
            Delete.Size = new Size(154, 48);
            Delete.TabIndex = 23;
            Delete.Text = "Delete User";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // UsernameDel
            // 
            UsernameDel.BackColor = Color.FromArgb(64, 0, 64);
            UsernameDel.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameDel.ForeColor = SystemColors.ButtonFace;
            UsernameDel.Location = new Point(54, 402);
            UsernameDel.Margin = new Padding(4, 5, 4, 5);
            UsernameDel.Name = "UsernameDel";
            UsernameDel.Size = new Size(188, 31);
            UsernameDel.TabIndex = 22;
            UsernameDel.Text = "Name";
            // 
            // SeeAllUsers
            // 
            SeeAllUsers.BackgroundColor = Color.FromArgb(64, 0, 64);
            SeeAllUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SeeAllUsers.GridColor = SystemColors.ActiveCaptionText;
            SeeAllUsers.Location = new Point(349, 207);
            SeeAllUsers.Margin = new Padding(4, 5, 4, 5);
            SeeAllUsers.Name = "SeeAllUsers";
            SeeAllUsers.RowHeadersWidth = 62;
            SeeAllUsers.RowTemplate.Height = 25;
            SeeAllUsers.Size = new Size(621, 465);
            SeeAllUsers.TabIndex = 29;
            // 
            // UpdateAllUsers
            // 
            UpdateAllUsers.BackColor = Color.Black;
            UpdateAllUsers.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateAllUsers.ForeColor = SystemColors.ControlLightLight;
            UpdateAllUsers.Location = new Point(876, 148);
            UpdateAllUsers.Margin = new Padding(4, 5, 4, 5);
            UpdateAllUsers.Name = "UpdateAllUsers";
            UpdateAllUsers.Size = new Size(94, 48);
            UpdateAllUsers.TabIndex = 30;
            UpdateAllUsers.Text = "Update";
            UpdateAllUsers.UseVisualStyleBackColor = false;
            UpdateAllUsers.Click += UpdateAllUsers_Click;
            // 
            // BackAdminSec
            // 
            BackAdminSec.BackColor = Color.Black;
            BackAdminSec.ForeColor = SystemColors.ButtonHighlight;
            BackAdminSec.Location = new Point(807, 703);
            BackAdminSec.Margin = new Padding(4, 5, 4, 5);
            BackAdminSec.Name = "BackAdminSec";
            BackAdminSec.Size = new Size(163, 53);
            BackAdminSec.TabIndex = 76;
            BackAdminSec.Text = "Back";
            BackAdminSec.UseVisualStyleBackColor = false;
            BackAdminSec.Click += BackAdminSec_Click;
            // 
            // EditUsers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(987, 777);
            Controls.Add(BackAdminSec);
            Controls.Add(UpdateAllUsers);
            Controls.Add(SeeAllUsers);
            Controls.Add(PasswordCreate);
            Controls.Add(Create);
            Controls.Add(UserCreate);
            Controls.Add(AdminLabel);
            Controls.Add(Delete);
            Controls.Add(UsernameDel);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(4, 5, 4, 5);
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