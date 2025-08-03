namespace Software_1_Project
{
    partial class Add_or_Modify_Product
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
            AllParts = new DataGridView();
            AssociatedParts = new DataGridView();
            AddPart = new Button();
            Remove = new Button();
            Save = new Button();
            Cancel = new Button();
            Search = new Button();
            SearchBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ID = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            TextName = new TextBox();
            Inventory = new TextBox();
            Price = new TextBox();
            Min = new TextBox();
            Max = new TextBox();
            ((System.ComponentModel.ISupportInitialize)AllParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AssociatedParts).BeginInit();
            SuspendLayout();
            // 
            // AllParts
            // 
            AllParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllParts.Location = new Point(343, 63);
            AllParts.Name = "AllParts";
            AllParts.Size = new Size(417, 104);
            AllParts.TabIndex = 0;
            // 
            // AssociatedParts
            // 
            AssociatedParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AssociatedParts.Location = new Point(343, 221);
            AssociatedParts.Name = "AssociatedParts";
            AssociatedParts.Size = new Size(417, 104);
            AssociatedParts.TabIndex = 1;
            // 
            // AddPart
            // 
            AddPart.Location = new Point(685, 173);
            AddPart.Name = "AddPart";
            AddPart.Size = new Size(75, 23);
            AddPart.TabIndex = 2;
            AddPart.Text = "Add";
            AddPart.UseVisualStyleBackColor = true;
            AddPart.Click += AddPart_Click;
            // 
            // Remove
            // 
            Remove.Location = new Point(685, 331);
            Remove.Name = "Remove";
            Remove.Size = new Size(75, 23);
            Remove.TabIndex = 3;
            Remove.Text = "Remove";
            Remove.UseVisualStyleBackColor = true;
            Remove.Click += Remove_Click;
            // 
            // Save
            // 
            Save.Location = new Point(632, 415);
            Save.Name = "Save";
            Save.Size = new Size(75, 23);
            Save.TabIndex = 4;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(713, 415);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(75, 23);
            Cancel.TabIndex = 5;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // Search
            // 
            Search.Location = new Point(531, 34);
            Search.Name = "Search";
            Search.Size = new Size(75, 23);
            Search.TabIndex = 6;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(612, 34);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(148, 23);
            SearchBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(343, 42);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 8;
            label1.Text = "All Parts";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(343, 203);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 9;
            label2.Text = "Associated Parts";
            // 
            // ID
            // 
            ID.Location = new Point(99, 63);
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Size = new Size(152, 23);
            ID.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 66);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 11;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 124);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 12;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 240);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 13;
            label5.Text = "Inventory";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 182);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 14;
            label6.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 298);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 15;
            label7.Text = "Min";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(163, 298);
            label8.Name = "label8";
            label8.Size = new Size(29, 15);
            label8.TabIndex = 16;
            label8.Text = "Max";
            // 
            // TextName
            // 
            TextName.Location = new Point(99, 121);
            TextName.Name = "TextName";
            TextName.Size = new Size(152, 23);
            TextName.TabIndex = 17;
            // 
            // Inventory
            // 
            Inventory.Location = new Point(99, 237);
            Inventory.Name = "Inventory";
            Inventory.Size = new Size(152, 23);
            Inventory.TabIndex = 18;
            // 
            // Price
            // 
            Price.Location = new Point(99, 179);
            Price.Name = "Price";
            Price.Size = new Size(152, 23);
            Price.TabIndex = 19;
            // 
            // Min
            // 
            Min.Location = new Point(81, 295);
            Min.Name = "Min";
            Min.Size = new Size(76, 23);
            Min.TabIndex = 20;
            // 
            // Max
            // 
            Max.Location = new Point(198, 295);
            Max.Name = "Max";
            Max.Size = new Size(76, 23);
            Max.TabIndex = 21;
            // 
            // Add_or_Modify_Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Max);
            Controls.Add(Min);
            Controls.Add(Price);
            Controls.Add(Inventory);
            Controls.Add(TextName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SearchBox);
            Controls.Add(Search);
            Controls.Add(Cancel);
            Controls.Add(Save);
            Controls.Add(Remove);
            Controls.Add(AddPart);
            Controls.Add(AssociatedParts);
            Controls.Add(AllParts);
            Name = "Add_or_Modify_Product";
            Text = "Add or Modify Product";
            ((System.ComponentModel.ISupportInitialize)AllParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)AssociatedParts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView AllParts;
        private DataGridView AssociatedParts;
        private Button AddPart;
        private Button Remove;
        private Button Save;
        private Button Cancel;
        private Button Search;
        private TextBox SearchBox;
        private Label label1;
        private Label label2;
        private TextBox ID;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox TextName;
        private TextBox Inventory;
        private TextBox Price;
        private TextBox Min;
        private TextBox Max;
    }
}