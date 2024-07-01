namespace Tanna
{
    partial class CreateFinalBoss
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
            label21 = new Label();
            FBCreated = new DataGridView();
            DelFB = new Button();
            label17 = new Label();
            NameDelFB = new TextBox();
            CreateFB = new Button();
            DamageFB = new TextBox();
            VelocityFB = new TextBox();
            LifeFB = new TextBox();
            NameFB = new TextBox();
            label5 = new Label();
            BackFB = new Button();
            label1 = new Label();
            label3 = new Label();
            Update = new Button();
            ((System.ComponentModel.ISupportInitialize)FBCreated).BeginInit();
            SuspendLayout();
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = SystemColors.ButtonHighlight;
            label21.Location = new Point(399, 55);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(243, 38);
            label21.TabIndex = 73;
            label21.Text = "Final Boss Created";
            // 
            // FBCreated
            // 
            FBCreated.BackgroundColor = Color.FromArgb(64, 0, 64);
            FBCreated.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FBCreated.Location = new Point(399, 133);
            FBCreated.Margin = new Padding(4, 5, 4, 5);
            FBCreated.Name = "FBCreated";
            FBCreated.RowHeadersWidth = 62;
            FBCreated.RowTemplate.Height = 25;
            FBCreated.Size = new Size(729, 517);
            FBCreated.TabIndex = 72;
            // 
            // DelFB
            // 
            DelFB.BackColor = Color.FromArgb(64, 0, 64);
            DelFB.ForeColor = SystemColors.ButtonHighlight;
            DelFB.Location = new Point(37, 487);
            DelFB.Margin = new Padding(4, 5, 4, 5);
            DelFB.Name = "DelFB";
            DelFB.Size = new Size(173, 47);
            DelFB.TabIndex = 71;
            DelFB.Text = "Delete Final Boss";
            DelFB.UseVisualStyleBackColor = false;
            DelFB.Click += DelFB_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.FromArgb(64, 0, 64);
            label17.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ButtonHighlight;
            label17.Location = new Point(37, 345);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(228, 38);
            label17.TabIndex = 70;
            label17.Text = "Delete Final Boss";
            // 
            // NameDelFB
            // 
            NameDelFB.BackColor = Color.FromArgb(64, 0, 64);
            NameDelFB.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NameDelFB.ForeColor = SystemColors.ButtonHighlight;
            NameDelFB.Location = new Point(37, 423);
            NameDelFB.Margin = new Padding(4, 5, 4, 5);
            NameDelFB.Name = "NameDelFB";
            NameDelFB.Size = new Size(171, 31);
            NameDelFB.TabIndex = 69;
            NameDelFB.Text = "Name";
            // 
            // CreateFB
            // 
            CreateFB.BackColor = Color.FromArgb(64, 0, 64);
            CreateFB.ForeColor = SystemColors.ButtonHighlight;
            CreateFB.Location = new Point(37, 257);
            CreateFB.Margin = new Padding(4, 5, 4, 5);
            CreateFB.Name = "CreateFB";
            CreateFB.Size = new Size(243, 47);
            CreateFB.TabIndex = 67;
            CreateFB.Text = "Create Final Boss";
            CreateFB.UseVisualStyleBackColor = false;
            CreateFB.Click += CreateFB_Click;
            // 
            // DamageFB
            // 
            DamageFB.BackColor = Color.FromArgb(64, 0, 64);
            DamageFB.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DamageFB.ForeColor = SystemColors.ButtonHighlight;
            DamageFB.Location = new Point(163, 193);
            DamageFB.Margin = new Padding(4, 5, 4, 5);
            DamageFB.Name = "DamageFB";
            DamageFB.Size = new Size(115, 31);
            DamageFB.TabIndex = 66;
            DamageFB.Text = "Damage";
            DamageFB.TextChanged += DamageFB_TextChanged;
            // 
            // VelocityFB
            // 
            VelocityFB.BackColor = Color.FromArgb(64, 0, 64);
            VelocityFB.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            VelocityFB.ForeColor = SystemColors.ButtonHighlight;
            VelocityFB.Location = new Point(163, 145);
            VelocityFB.Margin = new Padding(4, 5, 4, 5);
            VelocityFB.Name = "VelocityFB";
            VelocityFB.Size = new Size(115, 31);
            VelocityFB.TabIndex = 65;
            VelocityFB.Text = "Velocity";
            VelocityFB.TextChanged += VelocityFB_TextChanged;
            // 
            // LifeFB
            // 
            LifeFB.BackColor = Color.FromArgb(64, 0, 64);
            LifeFB.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LifeFB.ForeColor = SystemColors.ButtonHighlight;
            LifeFB.Location = new Point(37, 193);
            LifeFB.Margin = new Padding(4, 5, 4, 5);
            LifeFB.Name = "LifeFB";
            LifeFB.Size = new Size(115, 31);
            LifeFB.TabIndex = 61;
            LifeFB.Text = "Life";
            LifeFB.TextChanged += LifeFB_TextChanged;
            // 
            // NameFB
            // 
            NameFB.BackColor = Color.FromArgb(64, 0, 64);
            NameFB.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NameFB.ForeColor = SystemColors.ButtonHighlight;
            NameFB.Location = new Point(37, 145);
            NameFB.Margin = new Padding(4, 5, 4, 5);
            NameFB.Name = "NameFB";
            NameFB.Size = new Size(115, 31);
            NameFB.TabIndex = 60;
            NameFB.Text = "Name";
            NameFB.TextChanged += NameFB_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(64, 0, 64);
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(37, 55);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(139, 38);
            label5.TabIndex = 56;
            label5.Text = "Final Boss";
            // 
            // BackFB
            // 
            BackFB.BackColor = Color.Black;
            BackFB.ForeColor = SystemColors.Control;
            BackFB.Location = new Point(957, 673);
            BackFB.Margin = new Padding(4, 5, 4, 5);
            BackFB.Name = "BackFB";
            BackFB.Size = new Size(170, 53);
            BackFB.TabIndex = 74;
            BackFB.Text = "Back";
            BackFB.UseVisualStyleBackColor = false;
            BackFB.Click += BackFB_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(429, 673);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(317, 22);
            label1.TabIndex = 75;
            label1.Text = "Choose a Final Boss for the Game";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(399, 655);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(41, 48);
            label3.TabIndex = 84;
            label3.Text = "⬆️";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.UseMnemonic = false;
            // 
            // Update
            // 
            Update.BackColor = Color.Black;
            Update.ForeColor = SystemColors.Control;
            Update.Location = new Point(1020, 85);
            Update.Margin = new Padding(4, 5, 4, 5);
            Update.Name = "Update";
            Update.Size = new Size(107, 38);
            Update.TabIndex = 87;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click;
            // 
            // CreateFinalBoss
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(1169, 747);
            Controls.Add(Update);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(BackFB);
            Controls.Add(label21);
            Controls.Add(FBCreated);
            Controls.Add(DelFB);
            Controls.Add(label17);
            Controls.Add(NameDelFB);
            Controls.Add(CreateFB);
            Controls.Add(DamageFB);
            Controls.Add(VelocityFB);
            Controls.Add(LifeFB);
            Controls.Add(NameFB);
            Controls.Add(label5);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CreateFinalBoss";
            Text = "CreateFinalBoss";
            ((System.ComponentModel.ISupportInitialize)FBCreated).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label21;
        private DataGridView FBCreated;
        private Button DelFB;
        private Label label17;
        private TextBox NameDelFB;
        private Button CreateFB;
        private TextBox DamageFB;
        private TextBox VelocityFB;
        private TextBox LifeFB;
        private TextBox NameFB;
        private Label label5;
        private Button BackFB;
        private Label label1;
        private Label label3;
        private Button Update;
    }
}