using System;
using System.Collections.Generic;
using MarketSimulator.Entities.Enums;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketSimulator.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double totalPrice = 0;
            foreach(OrderItem item in Items)
            {
                totalPrice += item.SubTotal();
            }
            return totalPrice;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("G"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order items:");
            foreach(OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.Append("Total price: $");
            sb.AppendLine(Total().ToString());
            return sb.ToString();
        }
    }
}
