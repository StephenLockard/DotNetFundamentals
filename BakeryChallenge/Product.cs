using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryChallenge
{
    public enum BakeType { Bread, Cake, Pastry, Pie }
    public class Product
    {
        public BakeType Type { get; set; }
        public string ProductName { get; set; }
        public string CustomerName { get; set; }
        public int OrderSize { get; set; }
        public decimal OrderCost { get; set; }

        public Product(BakeType type, string productName, string customerName, int orderSize, decimal orderCost)
        {
            Type = type;
            ProductName = productName;
            CustomerName = customerName;
            OrderSize = orderSize;
            OrderCost = orderCost;
        }

        public Product()
        {

        }
    }
}
