using System;
using System.Collections.Generic;
using System.Text;

namespace _18._05homework.Models
{
    interface IOrder
    {
        public void ShowTheRemainingProduct();
        public void Order(List<Product> products, Order order);
        public void ShowOrder();
        public List<Order>Orders{ get;  }
    }
}
