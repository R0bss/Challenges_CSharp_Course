using System;
using System.Collections.Generic;
using System.Text;

namespace Enumercacoes_Composicoes.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        //public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int quantity,Product product)
        {
            Quantity = quantity;
            Product = product;
        }

        public double SubTotal()
        {
            return Product.Price * Quantity;
        }
    }
}
