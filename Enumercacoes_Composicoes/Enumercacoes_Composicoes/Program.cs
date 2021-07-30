using System;
using System.Globalization;
using Enumercacoes_Composicoes.Entities;
using Enumercacoes_Composicoes.Entities.Enums;

namespace Enumercacoes_Composicoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name,email,birthDate);
            Order order = new Order(DateTime.Now,orderStatus);
            

            Console.Write("How many items to this order? ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                int quant = int.Parse(Console.ReadLine());

                Product product = new Product(productName, price);
                OrderItem orderItem = new OrderItem(quant, product);
                
                order.AddItem(orderItem);
            }


            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine("Order moment: " + order.Moment);
            Console.WriteLine("Order Status: " + order.OrderStatus);
            Console.WriteLine("Client: " + client.Name + " (" + client.BirthDate + ") " + client.Email);
            Console.WriteLine("Order items: ");
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine(order);
            }
        }
    }
}
