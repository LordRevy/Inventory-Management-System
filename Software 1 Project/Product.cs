using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Software_1_Project
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();


        public Product(int productID, string name, decimal price, int inStock, int min, int max)
        {
            if (!Validator.IsInventoryValid(min, max, inStock))
            {
                throw new ArgumentException("Invalid inventory: Minimum amount must be less than or equal to Maximum, and InStock must fall between them.");
            }

            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }


        public void AddAssociatedPart(Part part)
        {
            if (AssociatedParts.Contains(part))
            {
                throw new ArgumentException("Part is already associated with this product.");
            }
            AssociatedParts.Add(part);
        }


        public Part LookupAssociatedPart(int partID)
        {
            foreach (Part p in AssociatedParts)
            {
                if (p.PartID == partID)
                {
                    return p;
                }
            }
            return null;
        }


        public bool RemoveAssociatedPart(int partID)
        {
            Part part = this.LookupAssociatedPart(partID);

            if (part != null)
            {
                AssociatedParts.Remove(part);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
