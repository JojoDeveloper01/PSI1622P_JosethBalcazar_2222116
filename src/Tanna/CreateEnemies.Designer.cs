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
            label12 = new Label();
            EnemiesCreated = new DataGridView();
            CreateGroupEnemies = new Button();
            label11 = new Label();
            AmountEnemies = new TextBox();
            NameEnemies = new TextBox();
            BackEnemies = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)EnemiesCreated).BeginInit();
            SuspendLayout();
            // 
            // DelEnemies
            // 
            DelEnemies.Location = new Point(31, 315);
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
            label16.Location = new Point(31, 235);
            label16.Name = "label16";
            label16.Size = new Size(141, 25);
            label16.TabIndex = 49;
            label16.Text = "Delete Enemies";
            // 
            // NameDelEnemies
            // 
            NameDelEnemies.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NameDelEnemies.Location = new Point(31, 279);
            NameDelEnemies.Name = "NameDelEnemies";
            NameDelEnemies.Size = new Size(100, 23);
            NameDelEnemies.TabIndex = 48;
            NameDelEnemies.Text = "Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(242, 41);
            label12.Name = "label12";
            label12.Size = new Size(153, 25);
            label12.TabIndex = 46;
            label12.Text = "Enemies Created";
            // 
            // EnemiesCreated
            // 
            EnemiesCreated.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EnemiesCreated.Location = new Point(242, 85);
            EnemiesCreated.Name = "EnemiesCreated";
            EnemiesCreated.RowTemplate.Height = 25;
            EnemiesCreated.Size = new Size(320, 286);
            EnemiesCreated.TabIndex = 45;
            // 
            // CreateGroupEnemies
            // 
            CreateGroupEnemies.Location = new Point(31, 143);
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
            label11.Location = new Point(31, 41);
            label11.Name = "label11";
            label11.Size = new Size(82, 25);
            label11.TabIndex = 43;
            label11.Text = "Enemies";
            // 
            // AmountEnemies
            // 
            AmountEnemies.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AmountEnemies.Location = new Point(31, 114);
            AmountEnemies.Name = "AmountEnemies";
            AmountEnemies.Size = new Size(120, 23);
            AmountEnemies.TabIndex = 41;
            AmountEnemies.Text = "Amount";
            // 
            // NameEnemies
            // 
            NameEnemies.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NameEnemies.Location = new Point(31, 85);
            NameEnemies.Name = "NameEnemies";
            NameEnemies.Size = new Size(120, 23);
            NameEnemies.TabIndex = 40;
            NameEnemies.Text = "Name";
            // 
            // BackEnemies
            // 
            BackEnemies.Location = new Point(443, 387);
            BackEnemies.Name = "BackEnemies";
            BackEnemies.Size = new Size(119, 32);
            BackEnemies.TabIndex = 51;
            BackEnemies.Text = "Back";
            BackEnemies.UseVisualStyleBackColor = true;
            BackEnemies.Click += BackEnemies_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(267, 385);
            label1.Name = "label1";
            label1.Size = new Size(154, 15);
            label1.TabIndex = 76;
            label1.Text = "Choose some Enemies";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(267, 404);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 77;
            label2.Text = "for your Game";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(242, 372);
            label3.Name = "label3";
            label3.Size = new Size(28, 32);
            label3.TabIndex = 85;
            label3.Text = "⬆️";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.UseMnemonic = false;
            // 
            // CreateEnemies
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(594, 430);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BackEnemies);
            Controls.Add(DelEnemies);
            Controls.Add(label16);
            Controls.Add(NameDelEnemies);
            Controls.Add(label12);
            Controls.Add(EnemiesCreated);
            Controls.Add(CreateGroupEnemies);
            Controls.Add(label11);
            Controls.Add(AmountEnemies);
            Controls.Add(NameEnemies);
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
        private Label label12;
        private DataGridView EnemiesCreated;
        private Button CreateGroupEnemies;
        private Label label11;
        private TextBox AmountEnemies;
        private TextBox NameEnemies;
        private Button BackEnemies;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}