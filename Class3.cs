using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_system
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            decimal finePerDay = 2.50m;
            int daysOverdue = 7;

            // Calculate total fine
            decimal totalFine = finePerDay * daysOverdue;

            // Display fine (rounded to 2 decimal places)
            decimal displayFine =
                Math.Round(totalFine, 2, MidpointRounding.AwayFromZero);

            // Log fine for analytics
            double analyticsFine = (double)displayFine;

            Console.WriteLine($"Fine to Pay: {displayFine}");
            Console.WriteLine($"Logged Fine (Analytics): {analyticsFine}");

        }
    }
}
