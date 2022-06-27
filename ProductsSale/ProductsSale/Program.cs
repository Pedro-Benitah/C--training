using System;
using System.Collections.Generic;
using System.Globalization;
using ProductsSale.Entities;

namespace ProductsSale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, udes or imported (c/u/i)? ");
                string tag = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                switch (tag)
                {
                    case "i":
                        Console.Write("Customs fee: ");
                        double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        products.Add(new ImportedProduct(name, price, fee));
                        break;
                    case "u":
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime dateTime = DateTime.Parse(Console.ReadLine());
                        products.Add(new UsedProduct(name, price, dateTime));
                        break;
                    default:
                        products.Add(new Product(name, price));
                        break;
                }
            }
            Console.WriteLine("\nPRICE TAGS:");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
