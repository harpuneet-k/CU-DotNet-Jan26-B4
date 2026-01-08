using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_system
{
    internal class Class2
    {
        static void Main(string[] args)
        {

            int s1 = 78, s2 = 85, s3 = 91;

            int total = s1 + s2 + s3;

            // Step 1: Accurate average
            double average = (double)total / 3;

            // Step 2: Display with precision
            double displayAverage =
                Math.Round(average, 2, MidpointRounding.AwayFromZero);

            // Step 3: Scholarship conversion
            int scholarshipAverage =
                (int)Math.Round(displayAverage, MidpointRounding.AwayFromZero);

            Console.WriteLine($"Average: {displayAverage}");
            Console.WriteLine($"Scholarship Score: {scholarshipAverage}");

        }
    }
}
