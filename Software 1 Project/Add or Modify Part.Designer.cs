namespace Software_1_Project
{
    partial class Add_or_Modify_Part
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
            Inhouse = new RadioButton();
            Outsourced = new RadioButton();
            IDText = new TextBox();
            NameText = new TextBox();
            InventoryText = new TextBox();
            IDLabel = new Label();
            NameLabel = new Label();
            InventoryLabel = new Label();
            PriceCostText = new TextBox();
            PriceCostLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            Mach_CompText = new TextBox();
            MachineID = new Label();
            MaxText = new TextBox();
            MinText = new TextBox();
            SaveButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(50, 30);
            label1.TabIndex = 0;
            label1.Text = "Part";
            // 
            // Inhouse
            // 
            Inhouse.AutoSize = true;
            Inhouse.Location = new Point(98, 20);
            Inhouse.Name = "Inhouse";
            Inhouse.Size = new Size(67, 19);
            Inhouse.TabIndex = 1;
            Inhouse.TabStop = true;
            Inhouse.Text = "Inhouse";
            Inhouse.UseVisualStyleBackColor = true;
            Inhouse.CheckedChanged += Inhouse_CheckedChanged;
            // 
            // Outsourced
            // 
            Outsourced.AutoSize = true;
            Outsourced.Location = new Point(198, 19);
            Outsourced.Name = "Outsourced";
            Outsourced.Size = new Size(87, 19);
            Outsourced.TabIndex = 2;
            Outsourced.TabStop = true;
            Outsourced.Text = "Outsourced";
            Outsourced.UseVisualStyleBackColor = true;
            Outsourced.CheckedChanged += Outsourced_CheckedChanged;
            // 
            // IDText
            // 
            IDText.Location = new Point(98, 78);
            IDText.Name = "IDText";
            IDText.ReadOnly = true;
            IDText.Size = new Size(187, 23);
            IDText.TabIndex = 3;
            // 
            // NameText
            // 
            NameText.Location = new Point(98, 107);
            NameText.Name = "NameText";
            NameText.Size = new Size(187, 23);
            NameText.TabIndex = 4;
            // 
            // InventoryText
            // 
            InventoryText.Location = new Point(98, 136);
            InventoryText.Name = "InventoryText";
            InventoryText.Size = new Size(187, 23);
            InventoryText.TabIndex = 5;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(74, 81);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(18, 15);
            IDLabel.TabIndex = 6;
            IDLabel.Text = "ID";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(53, 110);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 7;
            NameLabel.Text = "Name";
            // 
            // InventoryLabel
            // 
            InventoryLabel.AutoSize = true;
            InventoryLabel.Location = new Point(35, 139);
            InventoryLabel.Name = "InventoryLabel";
            InventoryLabel.Size = new Size(57, 15);
            InventoryLabel.TabIndex = 8;
            InventoryLabel.Text = "Inventory";
            // 
            // PriceCostText
            // 
            PriceCostText.Location = new Point(98, 165);
            PriceCostText.Name = "PriceCostText";
            PriceCostText.Size = new Size(187, 23);
            PriceCostText.TabIndex = 9;
            // 
            // PriceCostLabel
            // 
            PriceCostLabel.AutoSize = true;
            PriceCostLabel.Location = new Point(24, 168);
            PriceCostLabel.Name = "PriceCostLabel";
            PriceCostLabel.Size = new Size(68, 15);
            PriceCostLabel.TabIndex = 10;
            PriceCostLabel.Text = "Price / Cost";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 211);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 13;
            label2.Text = "Max";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(173, 211);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 14;
            label3.Text = "Min";
            // 
            // Mach_CompText
            // 
            Mach_CompText.Location = new Point(120, 287);
            Mach_CompText.Name = "Mach_CompText";
            Mach_CompText.Size = new Size(165, 23);
            Mach_CompText.TabIndex = 15;
            // 
            // MachineID
            // 
            MachineID.AutoSize = true;
            MachineID.Location = new Point(47, 290);
            MachineID.Name = "MachineID";
            MachineID.Size = new Size(67, 15);
            MachineID.TabIndex = 16;
            MachineID.Text = "Machine ID";
            // 
            // MaxText
            // 
            MaxText.Location = new Point(67, 208);
            MaxText.Name = "MaxText";
            MaxText.Size = new Size(100, 23);
            MaxText.TabIndex = 17;
            // 
            // MinText
            // 
            MinText.Location = new Point(207, 208);
            MinText.Name = "MinText";
            MinText.Size = new Size(100, 23);
            MinText.TabIndex = 18;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(12, 415);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 19;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(232, 415);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 20;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // Add_or_Modify_Part
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 450);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(MinText);
            Controls.Add(MaxText);
            Controls.Add(MachineID);
            Controls.Add(Mach_CompText);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PriceCostLabel);
            Controls.Add(PriceCostText);
            Controls.Add(InventoryLabel);
            Controls.Add(NameLabel);
            Controls.Add(IDLabel);
            Controls.Add(InventoryText);
            Controls.Add(NameText);
            Controls.Add(IDText);
            Controls.Add(Outsourced);
            Controls.Add(Inhouse);
            Controls.Add(label1);
            Name = "Add_or_Modify_Part";
            Text = "Add or Modify Part";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton Inhouse;
        private RadioButton Outsourced;
        private TextBox IDText;
        private TextBox NameText;
        private TextBox InventoryText;
        private Label IDLabel;
        private Label NameLabel;
        private Label InventoryLabel;
        private TextBox PriceCostText;
        private Label PriceCostLabel;
        private Label label2;
        private Label label3;
        private TextBox Mach_CompText;
        private Label MachineID;
        private TextBox MaxText;
        private TextBox MinText;
        private Button SaveButton;
        private Button CancelButton;
    }
}