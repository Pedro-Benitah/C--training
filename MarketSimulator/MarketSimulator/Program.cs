using System;
using System.Globalization;
using System.Collections.Generic;
using MarketSimulator.Entities;
using MarketSimulator.Entities.Enums;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, date);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product product = new Product(productName, productPrice);
                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());
                OrderItem item = new OrderItem(productQuantity, productPrice, product);
                order.AddItem(item);
            }

            Console.WriteLine(order);
        }
    }
}
