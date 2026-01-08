using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_system
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            // Cart total accumulated from item prices
            double cartTotal = 1999.99 + 499.50;

            // Tax and discount rules (financial logic)
            decimal taxRate = 18.0m;      // 18%
            decimal discountRate = 10.0m; // 10%

            // Convert cart total to decimal before financial calculations
            decimal cartTotalDecimal = (decimal)cartTotal;

            // Apply tax and discount
            decimal taxAmount = cartTotalDecimal * taxRate / 100;
            decimal discountAmount = cartTotalDecimal * discountRate / 100;

            // Final payable amount
            decimal finalAmount = cartTotalDecimal + taxAmount - discountAmount;

            Console.WriteLine($"Final Payable Amount: {finalAmount}");

        }
    }
}
