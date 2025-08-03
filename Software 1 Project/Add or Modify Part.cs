using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Software_1_Project
{
    public partial class Add_or_Modify_Part : Form
    {
        private Part currentPart;
        private bool isNewPart;

        public Add_or_Modify_Part(Part? part = null)
        {
            InitializeComponent();
            currentPart = part;
            isNewPart = true;

            if (currentPart != null)
            {
                isNewPart = false;
                PopulateFields();
            }
            else
            {
                IDText.Text = (main.inventory.GetNextID("Part")).ToString();
            }
        }
        private void PopulateFields()
        {
            IDText.Text = currentPart.PartID.ToString();
            NameText.Text = currentPart.Name;
            PriceCostText.Text = currentPart.Price.ToString();
            InventoryText.Text = currentPart.InStock.ToString();
            MinText.Text = currentPart.Min.ToString();
            MaxText.Text = currentPart.Max.ToString();
            
            if (currentPart is InHouse inHousePart)
            {
                Inhouse.Checked = true;
                Mach_CompText.Text = inHousePart.MachineID.ToString();
                MachineID.Text = "Machine ID";
                MachineID.Location = new Point(47, 290);
            }
            else if (currentPart is Outsourced outsourcedPart)
            {
                Outsourced.Checked = true;
                Mach_CompText.Text = outsourcedPart.CompanyName;
                MachineID.Text = "Company Name";
                MachineID.Location = new Point(20, 290);
            }
        }

        // Event handlers for radio buttons
        private void Inhouse_CheckedChanged(object sender, EventArgs e)
        {
            MachineID.Text = "Machine ID";
            MachineID.Location = new Point(47, 290);
        }

        private void Outsourced_CheckedChanged(object sender, EventArgs e)
        {
            MachineID.Text = "Company Name";
            MachineID.Location = new Point(20, 290);
        }

        // Save the part and close the form
        private void SaveButton_Click(object sender, EventArgs e)
        {

            // Validate input fields
            bool validateInventory = Validator.IsInteger(InventoryText.Text);
            bool validateMin = Validator.IsInteger(MinText.Text);
            bool validateMax = Validator.IsInteger(MaxText.Text);
            bool validatePrice = Validator.IsDecimal(PriceCostText.Text);
            bool validateMachineID = true;

            if (Inhouse.Checked)
            {
                validateMachineID = Validator.IsInteger(Mach_CompText.Text);
            }
            else
            {
                validateMachineID = Validator.IsString(Mach_CompText.Text);
            }

            if (!validateInventory || !validateMin || !validateMax || !validatePrice || !validateMachineID)
            {
                MessageBox.Show("Please ensure all fields are filled out correctly.");
                return;
            }

            int inStock = int.Parse(InventoryText.Text);
            int minStock = int.Parse(MinText.Text);
            int maxStock = int.Parse(MaxText.Text);

            if (!Validator.IsInventoryValid(minStock, maxStock, inStock))
            {
                MessageBox.Show("Inventory must be between Min and Max values.");
                return;
            }





            // Create a new part or update the existing one
            int partID = int.Parse(IDText.Text);
            string name = NameText.Text;
            decimal partPrice = decimal.Parse(PriceCostText.Text);

            Part newPart;

            if (Inhouse.Checked)
            {
                int machineID = int.Parse(Mach_CompText.Text);
                newPart = new InHouse(partID, name, partPrice, inStock, minStock, maxStock, machineID);
            }
            else
            {
                string companyName = Mach_CompText.Text;
                newPart = new Outsourced(partID, name, partPrice, inStock, minStock, maxStock, companyName);
            }

            if (isNewPart)
            {
                main.inventory.AddPart(newPart);
            }
            else
            {
                main.inventory.UpdatePart(newPart.PartID, newPart);
            }

            this.Close();
        }

        // Close the form without saving changes
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
