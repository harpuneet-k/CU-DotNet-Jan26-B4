using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_system
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            // Data usage tracked in bytes
            long usageBytes = 5_368_709_120; // example value

            // Implicit conversion: long → double
            double usageMB = usageBytes / (1024.0 * 1024.0);
            double usageGB = usageBytes / (1024.0 * 1024.0 * 1024.0);

            // Monthly summary (rounded to nearest integer)
            int roundedMB =
                (int)Math.Round(usageMB, MidpointRounding.AwayFromZero);

            int roundedGB =
                (int)Math.Round(usageGB, MidpointRounding.AwayFromZero);

            Console.WriteLine($"Usage: {usageMB:F2} MB");
            Console.WriteLine($"Usage: {usageGB:F2} GB");
            Console.WriteLine($"Monthly Summary: {roundedGB} GB");

        }
    }
}

// double usageMB = usageBytes / (1024.0 * 1024.0);
// long is implicitly converted to double.
// Safe because double can represent large integers approximately.
// Enables floating-point division.

// Math.Round(value, MidpointRounding.AwayFromZero);
// .5 values round up.
// Rounding is preferred over truncation for monthly summaries to avoid misleading reports.


