using System;
using System.Collections.Generic;
using System.Text;
using Exe_122.Entidades;
using Exe_122.Enums;
using System.Globalization;

namespace Exe_122.Entidades
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime monment, OrderStatus status, Client client)
        {
            Moment = monment;
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
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;

        }

        public override string ToString()
        {
            StringBuilder stringB = new StringBuilder();
            stringB.AppendLine("Order Moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            stringB.AppendLine("Order Starus: " + Status);
            stringB.AppendLine("Client: " + Client);
            stringB.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                stringB.AppendLine(item.ToString());
            }
            stringB.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return stringB.ToString();
        }
    }
}
