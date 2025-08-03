namespace Software_1_Project
{
    partial class main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PartModify = new Button();
            PartDelete = new Button();
            PartSearch = new Button();
            ProductAdd = new Button();
            ProductModify = new Button();
            ProductDelete = new Button();
            ProductSearchText = new TextBox();
            PartSearchText = new TextBox();
            PartAdd = new Button();
            ProductSearch = new Button();
            Exit = new Button();
            dataGridView1 = new DataGridView();
            partIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            inStockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            minDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maxDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            allPartsBindingSource = new BindingSource(components);
            inventoryBindingSource = new BindingSource(components);
            dataGridView2 = new DataGridView();
            productIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            inStockDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            minDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            maxDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            productsBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allPartsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // PartModify
            // 
            PartModify.Location = new Point(172, 191);
            PartModify.Name = "PartModify";
            PartModify.Size = new Size(75, 23);
            PartModify.TabIndex = 1;
            PartModify.Text = "Modify";
            PartModify.UseVisualStyleBackColor = true;
            PartModify.Click += PartModify_Click;
            // 
            // PartDelete
            // 
            PartDelete.Location = new Point(253, 192);
            PartDelete.Name = "PartDelete";
            PartDelete.Size = new Size(75, 23);
            PartDelete.TabIndex = 2;
            PartDelete.Text = "Delete";
            PartDelete.UseVisualStyleBackColor = true;
            PartDelete.Click += PartDelete_Click;
            // 
            // PartSearch
            // 
            PartSearch.Location = new Point(448, 192);
            PartSearch.Name = "PartSearch";
            PartSearch.Size = new Size(75, 23);
            PartSearch.TabIndex = 3;
            PartSearch.Text = "Search";
            PartSearch.UseVisualStyleBackColor = true;
            PartSearch.Click += PartSearch_Click;
            // 
            // ProductAdd
            // 
            ProductAdd.Location = new Point(91, 386);
            ProductAdd.Name = "ProductAdd";
            ProductAdd.Size = new Size(75, 23);
            ProductAdd.TabIndex = 7;
            ProductAdd.Text = "Add";
            ProductAdd.UseVisualStyleBackColor = true;
            ProductAdd.Click += ProductAdd_Click;
            // 
            // ProductModify
            // 
            ProductModify.Location = new Point(172, 386);
            ProductModify.Name = "ProductModify";
            ProductModify.Size = new Size(75, 23);
            ProductModify.TabIndex = 8;
            ProductModify.Text = "Modify";
            ProductModify.UseVisualStyleBackColor = true;
            ProductModify.Click += ProductModify_Click;
            // 
            // ProductDelete
            // 
            ProductDelete.Location = new Point(253, 386);
            ProductDelete.Name = "ProductDelete";
            ProductDelete.Size = new Size(75, 23);
            ProductDelete.TabIndex = 9;
            ProductDelete.Text = "Delete";
            ProductDelete.UseVisualStyleBackColor = true;
            ProductDelete.Click += ProductDelete_Click;
            // 
            // ProductSearchText
            // 
            ProductSearchText.Location = new Point(529, 386);
            ProductSearchText.Name = "ProductSearchText";
            ProductSearchText.Size = new Size(205, 23);
            ProductSearchText.TabIndex = 11;
            // 
            // PartSearchText
            // 
            PartSearchText.Location = new Point(529, 192);
            PartSearchText.Name = "PartSearchText";
            PartSearchText.Size = new Size(205, 23);
            PartSearchText.TabIndex = 12;
            // 
            // PartAdd
            // 
            PartAdd.Location = new Point(91, 192);
            PartAdd.Name = "PartAdd";
            PartAdd.Size = new Size(75, 23);
            PartAdd.TabIndex = 13;
            PartAdd.Text = "Add";
            PartAdd.UseVisualStyleBackColor = true;
            PartAdd.Click += PartAdd_Click;
            // 
            // ProductSearch
            // 
            ProductSearch.Location = new Point(448, 386);
            ProductSearch.Name = "ProductSearch";
            ProductSearch.Size = new Size(75, 23);
            ProductSearch.TabIndex = 14;
            ProductSearch.Text = "Search";
            ProductSearch.UseVisualStyleBackColor = true;
            ProductSearch.Click += ProductSearch_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(713, 415);
            Exit.Name = "Exit";
            Exit.Size = new Size(75, 23);
            Exit.TabIndex = 15;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { partIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, inStockDataGridViewTextBoxColumn, minDataGridViewTextBoxColumn, maxDataGridViewTextBoxColumn });
            dataGridView1.DataSource = allPartsBindingSource;
            dataGridView1.Location = new Point(91, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(643, 150);
            dataGridView1.TabIndex = 16;
            // 
            // partIDDataGridViewTextBoxColumn
            // 
            partIDDataGridViewTextBoxColumn.DataPropertyName = "PartID";
            partIDDataGridViewTextBoxColumn.HeaderText = "PartID";
            partIDDataGridViewTextBoxColumn.Name = "partIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // inStockDataGridViewTextBoxColumn
            // 
            inStockDataGridViewTextBoxColumn.DataPropertyName = "InStock";
            inStockDataGridViewTextBoxColumn.HeaderText = "InStock";
            inStockDataGridViewTextBoxColumn.Name = "inStockDataGridViewTextBoxColumn";
            // 
            // minDataGridViewTextBoxColumn
            // 
            minDataGridViewTextBoxColumn.DataPropertyName = "Min";
            minDataGridViewTextBoxColumn.HeaderText = "Min";
            minDataGridViewTextBoxColumn.Name = "minDataGridViewTextBoxColumn";
            // 
            // maxDataGridViewTextBoxColumn
            // 
            maxDataGridViewTextBoxColumn.DataPropertyName = "Max";
            maxDataGridViewTextBoxColumn.HeaderText = "Max";
            maxDataGridViewTextBoxColumn.Name = "maxDataGridViewTextBoxColumn";
            // 
            // allPartsBindingSource
            // 
            allPartsBindingSource.DataMember = "AllParts";
            allPartsBindingSource.DataSource = inventoryBindingSource;
            // 
            // inventoryBindingSource
            // 
            inventoryBindingSource.DataSource = typeof(Inventory);
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { productIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn1, priceDataGridViewTextBoxColumn1, inStockDataGridViewTextBoxColumn1, minDataGridViewTextBoxColumn1, maxDataGridViewTextBoxColumn1 });
            dataGridView2.DataSource = productsBindingSource;
            dataGridView2.Location = new Point(91, 236);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(643, 144);
            dataGridView2.TabIndex = 17;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            // 
            // inStockDataGridViewTextBoxColumn1
            // 
            inStockDataGridViewTextBoxColumn1.DataPropertyName = "InStock";
            inStockDataGridViewTextBoxColumn1.HeaderText = "InStock";
            inStockDataGridViewTextBoxColumn1.Name = "inStockDataGridViewTextBoxColumn1";
            // 
            // minDataGridViewTextBoxColumn1
            // 
            minDataGridViewTextBoxColumn1.DataPropertyName = "Min";
            minDataGridViewTextBoxColumn1.HeaderText = "Min";
            minDataGridViewTextBoxColumn1.Name = "minDataGridViewTextBoxColumn1";
            // 
            // maxDataGridViewTextBoxColumn1
            // 
            maxDataGridViewTextBoxColumn1.DataPropertyName = "Max";
            maxDataGridViewTextBoxColumn1.HeaderText = "Max";
            maxDataGridViewTextBoxColumn1.Name = "maxDataGridViewTextBoxColumn1";
            // 
            // productsBindingSource
            // 
            productsBindingSource.DataMember = "Products";
            productsBindingSource.DataSource = inventoryBindingSource;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(35, 36);
            label1.Name = "label1";
            label1.Size = new Size(50, 30);
            label1.TabIndex = 18;
            label1.Text = "Part";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(-3, 236);
            label2.Name = "label2";
            label2.Size = new Size(88, 30);
            label2.TabIndex = 19;
            label2.Text = "Product";
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(Exit);
            Controls.Add(ProductSearch);
            Controls.Add(PartAdd);
            Controls.Add(PartSearchText);
            Controls.Add(ProductSearchText);
            Controls.Add(ProductDelete);
            Controls.Add(ProductModify);
            Controls.Add(ProductAdd);
            Controls.Add(PartSearch);
            Controls.Add(PartDelete);
            Controls.Add(PartModify);
            Name = "main";
            Text = "Inventory Manager";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)allPartsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button PartModify;
        private Button PartDelete;
        private Button PartSearch;
        private Button ProductAdd;
        private Button ProductModify;
        private Button ProductDelete;
        private TextBox ProductSearchText;
        private TextBox PartSearchText;
        private Button PartAdd;
        private Button ProductSearch;
        private Button Exit;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
        private BindingSource allPartsBindingSource;
        private BindingSource inventoryBindingSource;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn minDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn1;
        private BindingSource productsBindingSource;
        private Label label1;
        private Label label2;
    }
}
