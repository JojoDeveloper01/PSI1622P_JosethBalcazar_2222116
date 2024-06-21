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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            NameWorld = new TextBox();
            SizeWorld = new TextBox();
            DurationWorld = new TextBox();
            label6 = new Label();
            AddWorlds = new Button();
            label20 = new Label();
            NameDelWorld = new TextBox();
            label19 = new Label();
            DelWorld = new Button();
            WorldsCreated = new DataGridView();
            label22 = new Label();
            ((System.ComponentModel.ISupportInitialize)WorldsCreated).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 91);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 120);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 1;
            label2.Text = "Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 146);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 2;
            label3.Text = "Duration seg";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 161);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 3;
            label4.Text = " (optional)";
            // 
            // NameWorld
            // 
            NameWorld.Location = new Point(81, 88);
            NameWorld.Name = "NameWorld";
            NameWorld.Size = new Size(100, 23);
            NameWorld.TabIndex = 4;
            // 
            // SizeWorld
            // 
            SizeWorld.Location = new Point(81, 117);
            SizeWorld.Name = "SizeWorld";
            SizeWorld.Size = new Size(100, 23);
            SizeWorld.TabIndex = 5;
            // 
            // DurationWorld
            // 
            DurationWorld.Location = new Point(81, 146);
            DurationWorld.Name = "DurationWorld";
            DurationWorld.Size = new Size(100, 23);
            DurationWorld.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(81, 44);
            label6.Name = "label6";
            label6.Size = new Size(63, 25);
            label6.TabIndex = 8;
            label6.Text = "World";
            // 
            // AddWorlds
            // 
            AddWorlds.Location = new Point(81, 189);
            AddWorlds.Name = "AddWorlds";
            AddWorlds.Size = new Size(100, 28);
            AddWorlds.TabIndex = 20;
            AddWorlds.Text = "Create World";
            AddWorlds.UseVisualStyleBackColor = true;
            AddWorlds.Click += CreateWorlds_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(32, 303);
            label20.Name = "label20";
            label20.Size = new Size(39, 15);
            label20.TabIndex = 41;
            label20.Text = "Name";
            // 
            // NameDelWorld
            // 
            NameDelWorld.Location = new Point(81, 302);
            NameDelWorld.Name = "NameDelWorld";
            NameDelWorld.Size = new Size(100, 23);
            NameDelWorld.TabIndex = 42;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(81, 256);
            label19.Name = "label19";
            label19.Size = new Size(122, 25);
            label19.TabIndex = 43;
            label19.Text = "Delete World";
            // 
            // DelWorld
            // 
            DelWorld.Location = new Point(81, 338);
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
            WorldsCreated.Location = new Point(272, 88);
            WorldsCreated.Name = "WorldsCreated";
            WorldsCreated.RowTemplate.Height = 25;
            WorldsCreated.Size = new Size(327, 278);
            WorldsCreated.TabIndex = 47;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(272, 40);
            label22.Name = "label22";
            label22.Size = new Size(142, 25);
            label22.TabIndex = 48;
            label22.Text = "Worlds Created";
            // 
            // CreateWorld
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(636, 416);
            Controls.Add(label22);
            Controls.Add(WorldsCreated);
            Controls.Add(DelWorld);
            Controls.Add(label19);
            Controls.Add(NameDelWorld);
            Controls.Add(label20);
            Controls.Add(AddWorlds);
            Controls.Add(label6);
            Controls.Add(DurationWorld);
            Controls.Add(SizeWorld);
            Controls.Add(NameWorld);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateWorld";
            Text = "CreatWorld";
            ((System.ComponentModel.ISupportInitialize)WorldsCreated).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox NameWorld;
        private TextBox SizeWorld;
        private TextBox DurationWorld;
        private Label label6;
        private Button AddWorlds;
        private Label label20;
        private TextBox NameDelWorld;
        private Label label19;
        private Button DelWorld;
        private DataGridView WorldsCreated;
        private Label label22;
    }
}