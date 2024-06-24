namespace Tanna
{
    partial class CreateEnemies
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
            DelEnemies = new Button();
            label16 = new Label();
            NameDelEnemies = new TextBox();
            label15 = new Label();
            label12 = new Label();
            EnemiesCreated = new DataGridView();
            CreateGroupEnemies = new Button();
            label11 = new Label();
            LifeEnemies = new TextBox();
            AmountEnemies = new TextBox();
            NameEnemies = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label35345 = new Label();
            BackEnemies = new Button();
            ((System.ComponentModel.ISupportInitialize)EnemiesCreated).BeginInit();
            SuspendLayout();
            // 
            // DelEnemies
            // 
            DelEnemies.Location = new Point(78, 315);
            DelEnemies.Name = "DelEnemies";
            DelEnemies.Size = new Size(100, 28);
            DelEnemies.TabIndex = 50;
            DelEnemies.Text = "Delete Enemies";
            DelEnemies.UseVisualStyleBackColor = true;
            DelEnemies.Click += DelEnemies_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(78, 235);
            label16.Name = "label16";
            label16.Size = new Size(141, 25);
            label16.TabIndex = 49;
            label16.Text = "Delete Enemies";
            // 
            // NameDelEnemies
            // 
            NameDelEnemies.Location = new Point(78, 279);
            NameDelEnemies.Name = "NameDelEnemies";
            NameDelEnemies.Size = new Size(100, 23);
            NameDelEnemies.TabIndex = 48;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(33, 282);
            label15.Name = "label15";
            label15.Size = new Size(39, 15);
            label15.TabIndex = 47;
            label15.Text = "Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(253, 41);
            label12.Name = "label12";
            label12.Size = new Size(153, 25);
            label12.TabIndex = 46;
            label12.Text = "Enemies Created";
            // 
            // EnemiesCreated
            // 
            EnemiesCreated.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EnemiesCreated.Location = new Point(253, 85);
            EnemiesCreated.Name = "EnemiesCreated";
            EnemiesCreated.RowTemplate.Height = 25;
            EnemiesCreated.Size = new Size(320, 286);
            EnemiesCreated.TabIndex = 45;
            // 
            // CreateGroupEnemies
            // 
            CreateGroupEnemies.Location = new Point(78, 176);
            CreateGroupEnemies.Name = "CreateGroupEnemies";
            CreateGroupEnemies.Size = new Size(120, 29);
            CreateGroupEnemies.TabIndex = 44;
            CreateGroupEnemies.Text = "Create Enemies";
            CreateGroupEnemies.UseVisualStyleBackColor = true;
            CreateGroupEnemies.Click += CreateGroupEnemies_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(78, 41);
            label11.Name = "label11";
            label11.Size = new Size(82, 25);
            label11.TabIndex = 43;
            label11.Text = "Enemies";
            // 
            // LifeEnemies
            // 
            LifeEnemies.Location = new Point(78, 143);
            LifeEnemies.Name = "LifeEnemies";
            LifeEnemies.Size = new Size(120, 23);
            LifeEnemies.TabIndex = 42;
            // 
            // AmountEnemies
            // 
            AmountEnemies.Location = new Point(78, 114);
            AmountEnemies.Name = "AmountEnemies";
            AmountEnemies.Size = new Size(120, 23);
            AmountEnemies.TabIndex = 41;
            // 
            // NameEnemies
            // 
            NameEnemies.Location = new Point(78, 85);
            NameEnemies.Name = "NameEnemies";
            NameEnemies.Size = new Size(120, 23);
            NameEnemies.TabIndex = 40;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(48, 146);
            label13.Name = "label13";
            label13.Size = new Size(26, 15);
            label13.TabIndex = 39;
            label13.Text = "Life";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(23, 117);
            label14.Name = "label14";
            label14.Size = new Size(51, 15);
            label14.TabIndex = 38;
            label14.Text = "Amount";
            // 
            // label35345
            // 
            label35345.AutoSize = true;
            label35345.Location = new Point(33, 88);
            label35345.Name = "label35345";
            label35345.Size = new Size(39, 15);
            label35345.TabIndex = 37;
            label35345.Text = "Name";
            // 
            // BackEnemies
            // 
            BackEnemies.Location = new Point(454, 387);
            BackEnemies.Name = "BackEnemies";
            BackEnemies.Size = new Size(119, 32);
            BackEnemies.TabIndex = 51;
            BackEnemies.Text = "Back";
            BackEnemies.UseVisualStyleBackColor = true;
            BackEnemies.Click += BackEnemies_Click;
            // 
            // CreateEnemies
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(602, 431);
            Controls.Add(BackEnemies);
            Controls.Add(DelEnemies);
            Controls.Add(label16);
            Controls.Add(NameDelEnemies);
            Controls.Add(label15);
            Controls.Add(label12);
            Controls.Add(EnemiesCreated);
            Controls.Add(CreateGroupEnemies);
            Controls.Add(label11);
            Controls.Add(LifeEnemies);
            Controls.Add(AmountEnemies);
            Controls.Add(NameEnemies);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label35345);
            Name = "CreateEnemies";
            Text = "CreateEnemies";
            ((System.ComponentModel.ISupportInitialize)EnemiesCreated).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DelEnemies;
        private Label label16;
        private TextBox NameDelEnemies;
        private Label label15;
        private Label label12;
        private DataGridView EnemiesCreated;
        private Button CreateGroupEnemies;
        private Label label11;
        private TextBox LifeEnemies;
        private TextBox AmountEnemies;
        private TextBox NameEnemies;
        private Label label13;
        private Label label14;
        private Label label35345;
        private Button BackEnemies;
    }
}