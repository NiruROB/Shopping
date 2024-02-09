using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    public class ClothingItem : InventoryItem, ISellable
    {

        public string Size { get; set; }

        public string Color { get; set; }


        public ClothingItem(string name, int quantity, int price, string size, string color)
        {

            Name = name;
            Quantity = quantity;
            Price = price;
            Size = size;
            Color = color;
        }

        public double CalculateSalePrice()
        {
            return Price * Quantity;
        }

    }
}
