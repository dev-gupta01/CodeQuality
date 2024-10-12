using CodeQuality.dev.Functions.Good;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuality.dev.Functions.Bad
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
            // Calculate Total Cost
            double total = 0;
            foreach(var item in orders.items)
            {
                total += item.price * item.quantity;
            }

            // Apply discount
            if (orders.customer.hasDiscount)
            {
                total -= total * 0.1;
            }

            // Update Inventory
            foreach (var item in orders.items)
            {
                UpdateInventory(item, item.quantity);
            }

            return total;
        }

        private void UpdateInventory(Item item, int quantity)
        {
            // Update Inventory
        }
    }
}
