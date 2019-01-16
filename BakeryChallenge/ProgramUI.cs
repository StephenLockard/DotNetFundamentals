using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryChallenge
{
    class ProgramUI
    {
        public void Run()
        {
            // this value creates a loop while true
            bool userContinue = true;

            // instantiate a new object
            Product product = new Product();
            ProductRepository repo = new ProductRepository();

            // do all of this code while userContinue = true
            do
            {
                Console.Clear();
                Console.WriteLine("Hello and welcome to our bakery! Please select a product from the menu: \n1) Bread \n2) Cake \n3) Pastry \n4) Pie\n  ");
                int userSelection = int.Parse(Console.ReadLine());
                
                switch (userSelection)
                {
                    case 1:
                        product.Type = BakeType.Bread;
                        break;
                    case 2:
                        product.Type = BakeType.Pie;
                        break;
                    case 3:
                        product.Type = BakeType.Pastry;
                        break;
                    case 4:
                        product.Type = BakeType.Cake;
                        break;
                    default:
                        Console.WriteLine("Nah fam");
                        break;
                }

                
                Console.WriteLine("What is your name?");
                product.CustomerName = Console.ReadLine();

                Console.WriteLine("What kind of tasty thing am I making for you?");
                product.ProductName = Console.ReadLine();

                Console.WriteLine("How many would you like?");
                product.OrderSize = int.Parse(Console.ReadLine());

                decimal totalCost = repo.CostOfCart(product.Type);
                product.OrderCost = totalCost;
                Console.WriteLine("\n" + product.CustomerName + " The price of your order of " + product.OrderSize + " " + product.ProductName + " " + product.Type + " is $" + totalCost + " per item");

                Console.ReadKey();

            }
            while (userContinue == true);
        }
    }
}
