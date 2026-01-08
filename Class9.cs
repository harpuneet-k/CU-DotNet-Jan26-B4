using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_system
{
    internal class Class9
    {
        static void Main(string[] args)
        {
            // Current inventory count (can be zero or positive)
            int itemCount = 450;

            // Maximum warehouse capacity (always non-negative)
            ushort maxCapacity = 500;

            // Convert capacity for safe comparison
            int capacityForComparison = maxCapacity;

            // Capacity check
            if (itemCount > capacityForComparison)
            {
                Console.WriteLine("Warning: Inventory exceeds maximum capacity!");
            }
            else
            {
                Console.WriteLine("Inventory is within capacity.");
            }

            // Reporting
            Console.WriteLine($"Items Stored: {itemCount}");
            Console.WriteLine($"Maximum Capacity: {capacityForComparison}");

        }
    }
}
