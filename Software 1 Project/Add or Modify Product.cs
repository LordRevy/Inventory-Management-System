using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Software_1_Project
{
    public partial class Add_or_Modify_Product : Form
    {
        private Product newProduct;
        private bool isNewPart;
        public Add_or_Modify_Product(Product? product = null)
        {
            InitializeComponent();
            AllParts.DataSource = main.inventory.AllParts;
            newProduct = product;
            isNewPart = true;

            if (newProduct != null)
            {
                isNewPart = false;
                AssociatedParts.DataSource = newProduct.AssociatedParts;
                PopulateFields();
            }
            else
            {
                ID.Text = (main.inventory.GetNextID("Product")).ToString();
            }
        }

        public void PopulateFields()
        {
            ID.Text = newProduct.ProductID.ToString();
            TextName.Text = newProduct.Name;
            Price.Text = newProduct.Price.ToString();
            Inventory.Text = newProduct.InStock.ToString();
            Min.Text = newProduct.Min.ToString();
            Max.Text = newProduct.Max.ToString();

        }

        private void Search_Click(object sender, EventArgs e)
        {
            string searchTerm = SearchBox.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a search term.");
                AllParts.DataSource = main.inventory.AllParts;
                return;
            }
            var results = main.inventory.AllParts.Where(p => p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
            if (results.Count == 0)
            {
                MessageBox.Show("No parts found matching the search term.");
                AllParts.DataSource = main.inventory.AllParts;
            }
            else
            {
                AllParts.DataSource = results;
            }
        }

        private void AddPart_Click(object sender, EventArgs e)
        {
            // Ensuring a part is selected and not in the process of creating a new part
            if (AllParts.CurrentRow == null)
            {
                MessageBox.Show("Please select a part to add.");
                return;
            }
            else if (isNewPart)
            {
                MessageBox.Show("Cannot add parts while creating a new product. Please save the product first, then modify it.");
                return;
            }

            Part selectedPart = (Part)AllParts.CurrentRow.DataBoundItem;
            try { newProduct.AddAssociatedPart(selectedPart); }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            Part partToRemove = (Part)AllParts.CurrentRow.DataBoundItem;
            if (partToRemove == null)
            {
                MessageBox.Show("Please select a part to remove.");
                return;
            }
            if (MessageBox.Show($"Are you sure you want to remove the part: {partToRemove.Name}?", "Confirm Remove", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                newProduct.RemoveAssociatedPart(partToRemove.PartID);
                partToRemove = null;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            // Validate inputs
            bool validateInventory = Validator.IsInteger(Inventory.Text);
            bool validateMin = Validator.IsInteger(Min.Text);
            bool validateMax = Validator.IsInteger(Max.Text);
            bool validatePrice = Validator.IsDecimal(Price.Text);

            if (!validateInventory || !validateMin || !validateMax || !validatePrice)
            {
                MessageBox.Show("Please ensure all fields are filled out correctly.");
                return;
            }

            int inStock = int.Parse(Inventory.Text);
            int minStock = int.Parse(Min.Text);
            int maxStock = int.Parse(Max.Text);

            if (!Validator.IsInventoryValid(minStock, maxStock, inStock))
            {
                MessageBox.Show("Inventory must be between Min and Max values.");
                return;
            }



            // Create a new product or update the existing one
            int productID = int.Parse(ID.Text);
            string name = TextName.Text;
            decimal productPrice = decimal.Parse(Price.Text);

            if (isNewPart)
            {
                Product newProduct = new Product(productID, name, productPrice, inStock, minStock, maxStock);
                main.inventory.AddProduct(newProduct);
            }
            else
            {
                newProduct.ProductID = productID;
                newProduct.Name = name;
                newProduct.Price = productPrice;
                newProduct.InStock = inStock;
                newProduct.Min = minStock;
                newProduct.Max = maxStock;

                main.inventory.UpdateProduct(newProduct.ProductID, newProduct);
            }

            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
