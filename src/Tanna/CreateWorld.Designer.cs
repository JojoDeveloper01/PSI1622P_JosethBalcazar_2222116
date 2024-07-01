namespace Tanna
{
    partial class CreateWorld
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
            label4 = new Label();
            NameWorld = new TextBox();
            SizeWorld = new TextBox();
            DurationWorld = new TextBox();
            label6 = new Label();
            AddWorlds = new Button();
            NameDelWorld = new TextBox();
            label19 = new Label();
            DelWorld = new Button();
            WorldsCreated = new DataGridView();
            label22 = new Label();
            BackWorld = new Button();
            label1 = new Label();
            label3 = new Label();
            Update = new Button();
            ((System.ComponentModel.ISupportInitialize)WorldsCreated).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(64, 0, 64);
            label4.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(191, 248);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 3;
            label4.Text = " (optional)";
            // 
            // NameWorld
            // 
            NameWorld.BackColor = Color.FromArgb(64, 0, 64);
            NameWorld.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NameWorld.ForeColor = SystemColors.ButtonHighlight;
            NameWorld.Location = new Point(54, 147);
            NameWorld.Margin = new Padding(4, 5, 4, 5);
            NameWorld.Name = "NameWorld";
            NameWorld.Size = new Size(141, 31);
            NameWorld.TabIndex = 4;
            NameWorld.Text = "Name";
            // 
            // SizeWorld
            // 
            SizeWorld.BackColor = Color.FromArgb(64, 0, 64);
            SizeWorld.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SizeWorld.ForeColor = SystemColors.ButtonHighlight;
            SizeWorld.Location = new Point(54, 195);
            SizeWorld.Margin = new Padding(4, 5, 4, 5);
            SizeWorld.Name = "SizeWorld";
            SizeWorld.Size = new Size(141, 31);
            SizeWorld.TabIndex = 5;
            SizeWorld.Text = "Size";
            // 
            // DurationWorld
            // 
            DurationWorld.BackColor = Color.FromArgb(64, 0, 64);
            DurationWorld.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DurationWorld.ForeColor = SystemColors.ButtonHighlight;
            DurationWorld.Location = new Point(54, 243);
            DurationWorld.Margin = new Padding(4, 5, 4, 5);
            DurationWorld.Name = "DurationWorld";
            DurationWorld.Size = new Size(141, 31);
            DurationWorld.TabIndex = 6;
            DurationWorld.Text = "Duration seg";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(64, 0, 64);
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(54, 67);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(91, 38);
            label6.TabIndex = 8;
            label6.Text = "World";
            // 
            // AddWorlds
            // 
            AddWorlds.BackColor = Color.Black;
            AddWorlds.ForeColor = SystemColors.ButtonHighlight;
            AddWorlds.Location = new Point(54, 315);
            AddWorlds.Margin = new Padding(4, 5, 4, 5);
            AddWorlds.Name = "AddWorlds";
            AddWorlds.Size = new Size(143, 47);
            AddWorlds.TabIndex = 20;
            AddWorlds.Text = "Create World";
            AddWorlds.UseVisualStyleBackColor = false;
            AddWorlds.Click += CreateWorlds_Click;
            // 
            // NameDelWorld
            // 
            NameDelWorld.BackColor = Color.FromArgb(64, 0, 64);
            NameDelWorld.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NameDelWorld.ForeColor = SystemColors.ButtonHighlight;
            NameDelWorld.Location = new Point(54, 497);
            NameDelWorld.Margin = new Padding(4, 5, 4, 5);
            NameDelWorld.Name = "NameDelWorld";
            NameDelWorld.Size = new Size(141, 31);
            NameDelWorld.TabIndex = 42;
            NameDelWorld.Text = "Name";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.FromArgb(64, 0, 64);
            label19.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = SystemColors.ButtonHighlight;
            label19.Location = new Point(54, 432);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(180, 38);
            label19.TabIndex = 43;
            label19.Text = "Delete World";
            // 
            // DelWorld
            // 
            DelWorld.BackColor = Color.Black;
            DelWorld.ForeColor = SystemColors.ButtonHighlight;
            DelWorld.Location = new Point(54, 563);
            DelWorld.Margin = new Padding(4, 5, 4, 5);
            DelWorld.Name = "DelWorld";
            DelWorld.Size = new Size(143, 47);
            DelWorld.TabIndex = 44;
            DelWorld.Text = "Delete World";
            DelWorld.UseVisualStyleBackColor = false;
            DelWorld.Click += DelWorld_Click;
            // 
            // WorldsCreated
            // 
            WorldsCreated.BackgroundColor = Color.FromArgb(64, 0, 64);
            WorldsCreated.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WorldsCreated.Location = new Point(343, 147);
            WorldsCreated.Margin = new Padding(4, 5, 4, 5);
            WorldsCreated.Name = "WorldsCreated";
            WorldsCreated.RowHeadersWidth = 62;
            WorldsCreated.RowTemplate.Height = 25;
            WorldsCreated.Size = new Size(491, 463);
            WorldsCreated.TabIndex = 47;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label22.ForeColor = SystemColors.ButtonFace;
            label22.Location = new Point(424, 67);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(207, 38);
            label22.TabIndex = 48;
            label22.Text = "Worlds Created";
            // 
            // BackWorld
            // 
            BackWorld.BackColor = Color.Black;
            BackWorld.ForeColor = SystemColors.ButtonHighlight;
            BackWorld.Location = new Point(640, 635);
            BackWorld.Margin = new Padding(4, 5, 4, 5);
            BackWorld.Name = "BackWorld";
            BackWorld.Size = new Size(194, 53);
            BackWorld.TabIndex = 52;
            BackWorld.Text = "Back";
            BackWorld.UseVisualStyleBackColor = false;
            BackWorld.Click += BackWorld_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(343, 673);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(275, 22);
            label1.TabIndex = 76;
            label1.Text = "Choose a World for the Game";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(343, 615);
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
            Update.Location = new Point(727, 98);
            Update.Margin = new Padding(4, 5, 4, 5);
            Update.Name = "Update";
            Update.Size = new Size(107, 38);
            Update.TabIndex = 86;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click;
            // 
            // CreateWorld
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(851, 713);
            Controls.Add(Update);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(BackWorld);
            Controls.Add(label22);
            Controls.Add(WorldsCreated);
            Controls.Add(DelWorld);
            Controls.Add(label19);
            Controls.Add(NameDelWorld);
            Controls.Add(AddWorlds);
            Controls.Add(label6);
            Controls.Add(DurationWorld);
            Controls.Add(SizeWorld);
            Controls.Add(NameWorld);
            Controls.Add(label4);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CreateWorld";
            Text = "CreatWorld";
            ((System.ComponentModel.ISupportInitialize)WorldsCreated).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private TextBox NameWorld;
        private TextBox SizeWorld;
        private TextBox DurationWorld;
        private Label label6;
        private Button AddWorlds;
        private TextBox NameDelWorld;
        private Label label19;
        private Button DelWorld;
        private DataGridView WorldsCreated;
        private Label label22;
        private Button BackWorld;
        private Label label1;
        private Label label3;
        private Button Update;
    }
}