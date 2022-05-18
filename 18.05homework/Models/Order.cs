using System;
using System.Collections.Generic;
using System.Text;

namespace _18._05homework
{
    class Order
    {
        public double TotalPrice;
        public DateTime Date;
        public List<Product> Products;
        public Order(List<Product>products, DateTime date)
        {
            Products = products;
            Date = date;
        }
        public double DisCount(List<Product> products)
        {
            foreach (Product item in products)
            {
                TotalPrice += item.Price * item.Count;

            }
            if (TotalPrice > 200)
            {
                TotalPrice -= 0.2 * TotalPrice;
            }
            else if (TotalPrice >= 100)
            {
                TotalPrice -= 0.1 * TotalPrice;
            }
            else
                return TotalPrice;

        }

    }
   
}
