using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Class10
    {
        static void Main(string[] args)
        {
            // Basic salary (fixed whole amount)
            int basicSalary = 50000;

            // Variable components
            double allowances = 12450.75;
            double deductions = 3250.25;

            // Convert to decimal for accurate payroll calculation
            decimal basicDecimal = basicSalary;
            decimal allowancesDecimal = (decimal)allowances;
            decimal deductionsDecimal = (decimal)deductions;

            // Net salary computation
            decimal netSalary = basicDecimal + allowancesDecimal - deductionsDecimal;

            Console.WriteLine($"Net Salary: {netSalary}");

        }
    }
}

// (Justification of Type Choices & Conversions)
// int for basic salary
//  Basic salary is a fixed whole number, so int is sufficient and efficient.
// double for allowances and deductions
//  These values may come from external systems or calculations and can contain fractional values.
// decimal for net salary
//  Payroll calculations require high precision; decimal avoids floating-point rounding errors.
