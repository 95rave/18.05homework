using _18._05homework.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _18._05homework.Sevices
{
    class OrderSevices : IOrder
    {
        List<Order> orders = new List<Order>();
        public List<Order> Orders => orders;
        public void Order(List<Product> products, Order order)
        {
            order.Products = products;
            orders.Add(order);
        }

        public void ShowOrder()
        {
            if (orders.Count==0)
            {
                Console.WriteLine("No Orders");
                return;
            }
            foreach (Order item in orders)
            {
                Console.WriteLine("Total Price:" + item.TotalPrice+"Date:" +item.Date);
                foreach (Product product in item.Products)
                {
                    Console.WriteLine(product);
                }
            }
        }

        public void ShowTheRemainingProduct()
        {
            if (GetProducts().Count==0)
            {
                Console.WriteLine("No Product");
                return;
            }
            foreach (Product item in GetProducts())
            {
                Console.WriteLine(item);
            }
        }
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            Product flour = new Product("flour", 25.5, 20);
            products.Add(flour);
            Product oil = new Product("oil", 14.5, 65);
            products.Add(oil);

            return products;

        }
    }

}
