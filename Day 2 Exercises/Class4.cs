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
// Why Types Are Used & Conversions
// decimal is used for account balance to ensure accurate financial calculations.
// float is used for interest rate because it comes from an external API and is suitable for approximate values.
// float cannot be implicitly converted to decimal because it may cause precision loss.
// Therefore, an explicit cast is required to safely convert float to decimal.
// All monetary calculations are performed in decimal to avoid rounding errors.



// Why Implicit Conversion May Fail
// float is a binary floating-point type and may not represent decimal values exactly.
// decimal is a high-precision base-10 type.
// Implicit conversion is disallowed by C# to prevent unintended financial inaccuracies.


