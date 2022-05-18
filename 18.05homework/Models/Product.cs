using System;
using System.Collections.Generic;
using System.Text;

namespace _18._05homework
{
    class Product
    {
       
        public string ProductName;
        public double Price;
        public ushort Count;


        public Product(string name, double price, ushort count)
        {
            ProductName = name;
            Price = price;
            Count = count;
        }
        public override string ToString()
        {
            return $"Product Namen: {ProductName} \nProduct Price: {Price} \nProduct Count: {Count}";
        }


    }
  
}
