using System.Security.Cryptography.X509Certificates;

namespace Software_1_Project
{
    public partial class main : Form
    {
        public static Inventory inventory = new Inventory();

        public main()
        {
            InitializeComponent();
            dataGridView1.DataSource = main.inventory.AllParts;
            dataGridView2.DataSource = main.inventory.Products;
        }





        // Part event handlers
        private void PartAdd_Click(object sender, EventArgs e)
        {
            Add_or_Modify_Part addOrModifyPartForm = new Add_or_Modify_Part();
            addOrModifyPartForm.ShowDialog();
        }

        private void PartModify_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a part to modify.");
                return;
            }

            Part selectedPart = (Part)dataGridView1.CurrentRow.DataBoundItem;

            Add_or_Modify_Part addOrModifyPartForm = new Add_or_Modify_Part(selectedPart);
            addOrModifyPartForm.ShowDialog();
        }

        private void PartDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a part to delete.");
                return;
            }

            Part selectedPart = (Part)dataGridView1.CurrentRow.DataBoundItem;
            foreach (Product product in inventory.Products)
            {
                if (product.AssociatedParts.Contains(selectedPart))
                {
                    MessageBox.Show($"Part: {selectedPart.Name} is associated with Product: {product.Name} and could not be deleted.");
                    return;
                }
            }

            if (MessageBox.Show($"Are you sure you want to delete the part: {selectedPart.Name}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                inventory.RemovePart(selectedPart.PartID);
            }
        }

        private void PartSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = PartSearchText.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a search term.");
                dataGridView1.DataSource = main.inventory.AllParts;
                return;
            }
            var results = main.inventory.AllParts.Where(p => p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
            if (results.Count == 0)
            {
                MessageBox.Show("No parts found matching the search term.");
                dataGridView1.DataSource = main.inventory.AllParts;
            }
            else
            {
                dataGridView1.DataSource = results;
            }
        }




        // Product event handlers
        private void ProductAdd_Click(object sender, EventArgs e)
        {
            Add_or_Modify_Product addOrModifyProductForm = new Add_or_Modify_Product();
            addOrModifyProductForm.ShowDialog();
        }

        private void ProductModify_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null)
            {
                MessageBox.Show("Please select a product to modify.");
                return;
            }

            Product selectedProduct = (Product)dataGridView2.CurrentRow.DataBoundItem;
            Add_or_Modify_Product addOrModifyProductForm = new Add_or_Modify_Product(selectedProduct);
            addOrModifyProductForm.ShowDialog();
        }

        private void ProductDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            Product selectedProduct = (Product)dataGridView2.CurrentRow.DataBoundItem;

            if (MessageBox.Show($"Are you sure you want to delete the product: {selectedProduct.Name}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                inventory.RemoveProduct(selectedProduct.ProductID);
            }
        }

        private void ProductSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = ProductSearchText.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a search term.");
                dataGridView2.DataSource = main.inventory.Products;
                return;
            }
            var results = main.inventory.Products.Where(p => p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
            if (results.Count == 0)
            {
                MessageBox.Show("No products found matching the search term.");
                dataGridView1.DataSource = main.inventory.Products;
            }
            else
            {
                dataGridView2.DataSource = results;
            }
        }




        // Exit application
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
