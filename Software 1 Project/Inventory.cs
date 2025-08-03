using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Software_1_Project
{
    public class Inventory
    {
        private int _nextProductID = 0;
        private int _nextPartID = 999;
        public BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public BindingList<Part> AllParts { get; set; } = new BindingList<Part>();

        public int GetNextID(string IDType)
        {
            if (IDType == "Part")
            {
                _nextPartID++;
                return _nextPartID;
            }
            else
            {
                _nextProductID++;
                return _nextProductID;
            }
        }





        // Product methods
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public bool RemoveProduct(int productID)
        {

            Product product = this.LookupProduct(productID);

            if (product != null)
            {
                Products.Remove(product);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Product LookupProduct(int productID)
        {
            foreach (Product p in Products)
            {
                if (p.ProductID == productID)
                {
                    return p;
                }
            }
            return null;
        }

        public void UpdateProduct(int productID, Product product)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == productID)
                {
                    Products[i] = product;
                    return;
                }
            }
        }





        // Part methods
        public void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        public bool RemovePart(int partID)
        {
            Part part = this.LookupPart(partID);

            if (part != null)
            {
                AllParts.Remove(part);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Part LookupPart(int partID)
        {
            foreach (Part p in AllParts)
            {
                if (p.PartID == partID)
                {
                    return p;
                }
            }
            return null;
        }

        public void UpdatePart(int partID, Part part)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID == partID)
                {
                    AllParts[i] = part;
                    return;
                }
            }
        }
    }
}
