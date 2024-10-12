using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuality.dev.Functions.Good
{
    public class Small
    {
        public double CalculateTotalPrice(int quantity, double unitPrice, double discount)
        {
            double total = CalculateSubtotal(quantity, unitPrice);
            return ApplyDiscount(total, discount);
        }

        private double CalculateSubtotal(int quantity, double unitPrice)
        {
            return quantity * unitPrice;
        }

        private double ApplyDiscount(double total, double discount)
        {
            if (discount > 0)
            {
                total -= total * discount;
            }
            return total;
        }
    }
}
