using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_1_Project
{
    public class Validator
    {
        public static bool IsInventoryValid(int min, int max, int inStock)
        {
            return (min <= inStock && inStock <= max && min <= max);
        }

        public static bool IsInteger(string input)
        {
            return int.TryParse(input, out _);
        }

        public static bool IsDecimal(string input)
        {
            return decimal.TryParse(input, out _);
        }

        public static bool IsString(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }
    }
}
