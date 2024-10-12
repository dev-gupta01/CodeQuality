using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuality.dev.Functions.Bad
{
    public class Small
    {
        // Unoptimized, long method
        public double CalculateTotalPrice(int quantity, double unitPrice, double discount)
        {
            double total = quantity * unitPrice;
            if (discount > 0)
            {
                total -= total * discount;
            }
            return total;
        }
    }
}
