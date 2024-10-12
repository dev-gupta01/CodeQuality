using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuality.dev.Functions.Good
{
    public class Customer
    {
        public bool hasDiscount;
    }

    public class Item
    {
        public int price;
        public int quantity;
    }

    public class Orders
    {
        public List<Item> items;
        public Customer customer;
    }

    public class DoOneThing
    {
        public double CalculateOrderTotal(Orders orders)
        {
            double total = CalculateTotalCost(orders);
            total = ApplyDiscount(orders, total);
            UpdateInventory(orders);

            return total;
        }

        public double CalculateTotalCost(Orders orders)
        {
            double total = 0;
            foreach(var item in orders.items)
            {
                total += item.price * item.quantity;
            }

            return total;
        }

        public double ApplyDiscount(Orders orders, double total)
        {
            if(orders.customer.hasDiscount)
            {
                total -= total * 0.1;
            }

            return total;
        }

        public void UpdateInventory(Orders orders)
        {
            // logic
        }
    }
}
