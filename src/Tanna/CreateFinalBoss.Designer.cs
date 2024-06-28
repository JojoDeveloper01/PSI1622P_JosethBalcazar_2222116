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
            EnergyFB = new TextBox();
            VelocityFB = new TextBox();
            LifeFB = new TextBox();
            NameFB = new TextBox();
            label5 = new Label();
            BackFB = new Button();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)FBCreated).BeginInit();
            SuspendLayout();
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(279, 33);
            label21.Name = "label21";
            label21.Size = new Size(166, 25);
            label21.TabIndex = 73;
            label21.Text = "Final Boss Created";
            // 
            // FBCreated
            // 
            FBCreated.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FBCreated.Location = new Point(279, 80);
            FBCreated.Name = "FBCreated";
            FBCreated.RowTemplate.Height = 25;
            FBCreated.Size = new Size(510, 310);
            FBCreated.TabIndex = 72;
            // 
            // DelFB
            // 
            DelFB.Location = new Point(26, 292);
            DelFB.Name = "DelFB";
            DelFB.Size = new Size(121, 28);
            DelFB.TabIndex = 71;
            DelFB.Text = "Delete Final Boss";
            DelFB.UseVisualStyleBackColor = true;
            DelFB.Click += DelFB_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(26, 207);
            label17.Name = "label17";
            label17.Size = new Size(154, 25);
            label17.TabIndex = 70;
            label17.Text = "Delete Final Boss";
            // 
            // NameDelFB
            // 
            NameDelFB.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NameDelFB.Location = new Point(26, 254);
            NameDelFB.Name = "NameDelFB";
            NameDelFB.Size = new Size(121, 23);
            NameDelFB.TabIndex = 69;
            NameDelFB.Text = "Name";
            // 
            // CreateFB
            // 
            CreateFB.Location = new Point(26, 154);
            CreateFB.Name = "CreateFB";
            CreateFB.Size = new Size(170, 28);
            CreateFB.TabIndex = 67;
            CreateFB.Text = "Create Final Boss";
            CreateFB.UseVisualStyleBackColor = true;
            CreateFB.Click += CreateFB_Click;
            // 
            // EnergyFB
            // 
            EnergyFB.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EnergyFB.Location = new Point(114, 116);
            EnergyFB.Name = "EnergyFB";
            EnergyFB.Size = new Size(82, 23);
            EnergyFB.TabIndex = 66;
            EnergyFB.Text = "Energy";
            EnergyFB.TextChanged += EnergyFB_TextChanged;
            // 
            // VelocityFB
            // 
            VelocityFB.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            VelocityFB.Location = new Point(114, 87);
            VelocityFB.Name = "VelocityFB";
            VelocityFB.Size = new Size(82, 23);
            VelocityFB.TabIndex = 65;
            VelocityFB.Text = "Velocity";
            VelocityFB.TextChanged += VelocityFB_TextChanged;
            // 
            // LifeFB
            // 
            LifeFB.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LifeFB.Location = new Point(26, 116);
            LifeFB.Name = "LifeFB";
            LifeFB.Size = new Size(82, 23);
            LifeFB.TabIndex = 61;
            LifeFB.Text = "Life";
            LifeFB.TextChanged += LifeFB_TextChanged;
            // 
            // NameFB
            // 
            NameFB.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NameFB.Location = new Point(26, 87);
            NameFB.Name = "NameFB";
            NameFB.Size = new Size(82, 23);
            NameFB.TabIndex = 60;
            NameFB.Text = "Name";
            NameFB.TextChanged += NameFB_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(26, 33);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 56;
            label5.Text = "Final Boss";
            // 
            // BackFB
            // 
            BackFB.Location = new Point(670, 404);
            BackFB.Name = "BackFB";
            BackFB.Size = new Size(119, 32);
            BackFB.TabIndex = 74;
            BackFB.Text = "Back";
            BackFB.UseVisualStyleBackColor = true;
            BackFB.Click += BackFB_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(300, 404);
            label1.Name = "label1";
            label1.Size = new Size(225, 15);
            label1.TabIndex = 75;
            label1.Text = "Choose a Final Boss for the Game";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(279, 393);
            label3.Name = "label3";
            label3.Size = new Size(28, 32);
            label3.TabIndex = 84;
            label3.Text = "⬆️";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.UseMnemonic = false;
            // 
            // CreateFinalBoss
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(818, 448);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(BackFB);
            Controls.Add(label21);
            Controls.Add(FBCreated);
            Controls.Add(DelFB);
            Controls.Add(label17);
            Controls.Add(NameDelFB);
            Controls.Add(CreateFB);
            Controls.Add(EnergyFB);
            Controls.Add(VelocityFB);
            Controls.Add(LifeFB);
            Controls.Add(NameFB);
            Controls.Add(label5);
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
        private TextBox EnergyFB;
        private TextBox VelocityFB;
        private TextBox LifeFB;
        private TextBox NameFB;
        private Label label5;
        private Button BackFB;
        private Label label1;
        private Label label3;
    }
}