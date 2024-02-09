using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree

{
    internal class ElectronicItem : InventoryItem, ISellable
    {
        public string Forsikringsinformasjon {  get; set; }
        public int Spenning {  get; set; }

        public ElectronicItem(string name, int quantity, int price, string forsikringsinformasjon, int spenning ) 
        {
            Name = name;
            Quantity = quantity;
            Price = price;
            Forsikringsinformasjon = forsikringsinformasjon;
            Spenning = spenning;
        }
        public double CalculateSalePrice()
        {
            return Price * Quantity;
        }
    }
}
