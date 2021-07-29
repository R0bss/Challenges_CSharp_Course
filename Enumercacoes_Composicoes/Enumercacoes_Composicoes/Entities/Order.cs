using System;
using System.Collections.Generic;
using System.Text;
using Enumercacoes_Composicoes.Entities.Enums;

namespace Enumercacoes_Composicoes.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public List<OrderItem> Items { get; private set } = new List<OrderItem>();
        public Order()
        {

        }
        public Order(DateTime moment, OrderStatus orderStatus)
        {
            Moment = moment;
            OrderStatus = orderStatus;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveContract(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }
    }
}
