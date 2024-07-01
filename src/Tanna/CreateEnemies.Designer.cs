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
            Update = new Button();
            ((System.ComponentModel.ISupportInitialize)EnemiesCreated).BeginInit();
            SuspendLayout();
            // 
            // DelEnemies
            // 
            DelEnemies.BackColor = Color.FromArgb(64, 0, 64);
            DelEnemies.ForeColor = SystemColors.ControlLightLight;
            DelEnemies.Location = new Point(44, 525);
            DelEnemies.Margin = new Padding(4, 5, 4, 5);
            DelEnemies.Name = "DelEnemies";
            DelEnemies.Size = new Size(143, 47);
            DelEnemies.TabIndex = 50;
            DelEnemies.Text = "Delete Enemies";
            DelEnemies.UseVisualStyleBackColor = false;
            DelEnemies.Click += DelEnemies_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.FromArgb(64, 0, 64);
            label16.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ControlLightLight;
            label16.Location = new Point(44, 392);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(209, 38);
            label16.TabIndex = 49;
            label16.Text = "Delete Enemies";
            // 
            // NameDelEnemies
            // 
            NameDelEnemies.BackColor = Color.FromArgb(64, 0, 64);
            NameDelEnemies.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NameDelEnemies.ForeColor = SystemColors.ControlLightLight;
            NameDelEnemies.Location = new Point(44, 465);
            NameDelEnemies.Margin = new Padding(4, 5, 4, 5);
            NameDelEnemies.Name = "NameDelEnemies";
            NameDelEnemies.Size = new Size(141, 31);
            NameDelEnemies.TabIndex = 48;
            NameDelEnemies.Text = "Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(346, 68);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(224, 38);
            label12.TabIndex = 46;
            label12.Text = "Enemies Created";
            // 
            // EnemiesCreated
            // 
            EnemiesCreated.BackgroundColor = Color.FromArgb(64, 0, 64);
            EnemiesCreated.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EnemiesCreated.Location = new Point(346, 142);
            EnemiesCreated.Margin = new Padding(4, 5, 4, 5);
            EnemiesCreated.Name = "EnemiesCreated";
            EnemiesCreated.RowHeadersWidth = 62;
            EnemiesCreated.RowTemplate.Height = 25;
            EnemiesCreated.Size = new Size(457, 477);
            EnemiesCreated.TabIndex = 45;
            // 
            // CreateGroupEnemies
            // 
            CreateGroupEnemies.BackColor = Color.FromArgb(64, 0, 64);
            CreateGroupEnemies.ForeColor = SystemColors.ControlLightLight;
            CreateGroupEnemies.Location = new Point(44, 238);
            CreateGroupEnemies.Margin = new Padding(4, 5, 4, 5);
            CreateGroupEnemies.Name = "CreateGroupEnemies";
            CreateGroupEnemies.Size = new Size(171, 48);
            CreateGroupEnemies.TabIndex = 44;
            CreateGroupEnemies.Text = "Create Enemies";
            CreateGroupEnemies.UseVisualStyleBackColor = false;
            CreateGroupEnemies.Click += CreateGroupEnemies_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(64, 0, 64);
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(44, 68);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(120, 38);
            label11.TabIndex = 43;
            label11.Text = "Enemies";
            // 
            // AmountEnemies
            // 
            AmountEnemies.BackColor = Color.FromArgb(64, 0, 64);
            AmountEnemies.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AmountEnemies.ForeColor = SystemColors.ControlLightLight;
            AmountEnemies.Location = new Point(44, 190);
            AmountEnemies.Margin = new Padding(4, 5, 4, 5);
            AmountEnemies.Name = "AmountEnemies";
            AmountEnemies.Size = new Size(170, 31);
            AmountEnemies.TabIndex = 41;
            AmountEnemies.Text = "Amount";
            // 
            // NameEnemies
            // 
            NameEnemies.BackColor = Color.FromArgb(64, 0, 64);
            NameEnemies.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NameEnemies.ForeColor = SystemColors.ControlLightLight;
            NameEnemies.Location = new Point(44, 142);
            NameEnemies.Margin = new Padding(4, 5, 4, 5);
            NameEnemies.Name = "NameEnemies";
            NameEnemies.Size = new Size(170, 31);
            NameEnemies.TabIndex = 40;
            NameEnemies.Text = "Name";
            // 
            // BackEnemies
            // 
            BackEnemies.BackColor = Color.Black;
            BackEnemies.ForeColor = SystemColors.ButtonHighlight;
            BackEnemies.Location = new Point(633, 645);
            BackEnemies.Margin = new Padding(4, 5, 4, 5);
            BackEnemies.Name = "BackEnemies";
            BackEnemies.Size = new Size(170, 53);
            BackEnemies.TabIndex = 51;
            BackEnemies.Text = "Back";
            BackEnemies.UseVisualStyleBackColor = false;
            BackEnemies.Click += BackEnemies_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(381, 642);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(213, 22);
            label1.TabIndex = 76;
            label1.Text = "Choose some Enemies";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(381, 673);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 22);
            label2.TabIndex = 77;
            label2.Text = "for your Game";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(346, 620);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(41, 48);
            label3.TabIndex = 85;
            label3.Text = "⬆️";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.UseMnemonic = false;
            // 
            // Update
            // 
            Update.BackColor = Color.Black;
            Update.ForeColor = SystemColors.ButtonHighlight;
            Update.Location = new Point(696, 93);
            Update.Margin = new Padding(4, 5, 4, 5);
            Update.Name = "Update";
            Update.Size = new Size(107, 38);
            Update.TabIndex = 86;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click;
            // 
            // CreateEnemies
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(849, 717);
            Controls.Add(Update);
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
            Margin = new Padding(4, 5, 4, 5);
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
        private Button Update;
    }
}