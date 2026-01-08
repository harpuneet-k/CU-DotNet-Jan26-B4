using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_system
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            decimal accountBalance = 100000.00m;

            // Interest rate from external API (float)
            float interestRate = 7.5f;   // annual percentage rate

            // Explicit conversion of float to decimal
            decimal rateDecimal = (decimal)interestRate;

            // Monthly interest calculation
            decimal monthlyInterest =
                accountBalance * rateDecimal / 100 / 12;

            // Update balance
            accountBalance += monthlyInterest;

            Console.WriteLine($"Updated Balance: {accountBalance}");

        }
    }
}
