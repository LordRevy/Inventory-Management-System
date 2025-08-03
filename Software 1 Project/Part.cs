using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_1_Project
{
    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }


        public Part(int partID, string name, decimal price, int inStock, int min, int max)
        {
            if (!Validator.IsInventoryValid(min, max, inStock))
            {
                throw new ArgumentException("Invalid inventory: Minimum amount must be less than or equal to Maximum, and InStock must fall between them.");
            }

            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
    }

    // InHouse Part Class
    public class InHouse : Part
    {
        public int MachineID { get; set; }


        public InHouse(int partID, string name, decimal price, int inStock, int min, int max, int machineID)
            : base(partID, name, price, inStock, min, max)
        {
            MachineID = machineID;
        }
    }


    // Outsourced Part Class
    public class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced(int partID, string name, decimal price, int inStock, int min, int max, string companyName)
            : base(partID, name, price, inStock, min, max)
        {
            CompanyName = companyName;
        }
    }
}
