using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryChallenge
{
    public class ProductRepository
    {
        List<Product> productCart = new List<Product>();

        public void AppendToList(Product bakedGood)
        {
            productCart.Add(bakedGood);
        }

        public void RemoveFromList(Product bakedGood)
        {
            productCart.Remove(bakedGood);
        }

        public List<Product> GetListOfProducts()
        {
            return productCart;
        }

        public decimal CostOfCart(BakeType type)
        {
            decimal totalCost = 100m;

            switch (type)
            {
                case BakeType.Bread:
                    totalCost += 500.01m;
                    break;
                case BakeType.Cake:
                    totalCost += 2000m;
                    break;
                case BakeType.Pastry:
                    totalCost += 200.10m;
                    break;
                case BakeType.Pie:
                    totalCost += 851.50m;
                    break;
            }
            return totalCost;
        }
        
    }
}
