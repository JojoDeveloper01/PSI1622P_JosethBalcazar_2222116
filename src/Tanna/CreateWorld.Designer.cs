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
            ((System.ComponentModel.ISupportInitialize)WorldsCreated).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(134, 149);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = " (optional)";
            // 
            // NameWorld
            // 
            NameWorld.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NameWorld.Location = new Point(38, 88);
            NameWorld.Name = "NameWorld";
            NameWorld.Size = new Size(100, 23);
            NameWorld.TabIndex = 4;
            NameWorld.Text = "Name";
            // 
            // SizeWorld
            // 
            SizeWorld.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SizeWorld.Location = new Point(38, 117);
            SizeWorld.Name = "SizeWorld";
            SizeWorld.Size = new Size(100, 23);
            SizeWorld.TabIndex = 5;
            SizeWorld.Text = "Size";
            // 
            // DurationWorld
            // 
            DurationWorld.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DurationWorld.Location = new Point(38, 146);
            DurationWorld.Name = "DurationWorld";
            DurationWorld.Size = new Size(100, 23);
            DurationWorld.TabIndex = 6;
            DurationWorld.Text = "Duration seg";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(38, 40);
            label6.Name = "label6";
            label6.Size = new Size(63, 25);
            label6.TabIndex = 8;
            label6.Text = "World";
            // 
            // AddWorlds
            // 
            AddWorlds.Location = new Point(38, 189);
            AddWorlds.Name = "AddWorlds";
            AddWorlds.Size = new Size(100, 28);
            AddWorlds.TabIndex = 20;
            AddWorlds.Text = "Create World";
            AddWorlds.UseVisualStyleBackColor = true;
            AddWorlds.Click += CreateWorlds_Click;
            // 
            // NameDelWorld
            // 
            NameDelWorld.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NameDelWorld.Location = new Point(38, 298);
            NameDelWorld.Name = "NameDelWorld";
            NameDelWorld.Size = new Size(100, 23);
            NameDelWorld.TabIndex = 42;
            NameDelWorld.Text = "Name";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(38, 259);
            label19.Name = "label19";
            label19.Size = new Size(122, 25);
            label19.TabIndex = 43;
            label19.Text = "Delete World";
            // 
            // DelWorld
            // 
            DelWorld.Location = new Point(38, 338);
            DelWorld.Name = "DelWorld";
            DelWorld.Size = new Size(100, 28);
            DelWorld.TabIndex = 44;
            DelWorld.Text = "Delete World";
            DelWorld.UseVisualStyleBackColor = true;
            DelWorld.Click += DelWorld_Click;
            // 
            // WorldsCreated
            // 
            WorldsCreated.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WorldsCreated.Location = new Point(240, 88);
            WorldsCreated.Name = "WorldsCreated";
            WorldsCreated.RowTemplate.Height = 25;
            WorldsCreated.Size = new Size(344, 278);
            WorldsCreated.TabIndex = 47;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(297, 40);
            label22.Name = "label22";
            label22.Size = new Size(142, 25);
            label22.TabIndex = 48;
            label22.Text = "Worlds Created";
            // 
            // BackWorld
            // 
            BackWorld.Location = new Point(448, 381);
            BackWorld.Name = "BackWorld";
            BackWorld.Size = new Size(136, 32);
            BackWorld.TabIndex = 52;
            BackWorld.Text = "Back";
            BackWorld.UseVisualStyleBackColor = true;
            BackWorld.Click += BackWorld_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SansSerif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(240, 391);
            label1.Name = "label1";
            label1.Size = new Size(174, 14);
            label1.TabIndex = 76;
            label1.Text = "Choose a World for the Game";
            // 
            // CreateWorld
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(596, 428);
            Controls.Add(label1);
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
    }
}