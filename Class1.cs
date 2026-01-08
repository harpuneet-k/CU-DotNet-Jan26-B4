using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_system
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the no. of classes attended: ");
            int classesAttended = int.Parse(Console.ReadLine());
            Console.Write("Total no. of classes: ");
            int totalClassesHeld = int.Parse(Console.ReadLine());
            double attendancePercentage =
    (double)classesAttended / totalClassesHeld * 100;

            Console.WriteLine("Actual Percentage:"+attendancePercentage);


            //Truncate
            int displayPercentage = (int)attendancePercentage;
            Console.WriteLine("Attendance percentage: "+displayPercentage+"%");

            // Convert safely for display
            int eligibilityPercentage =
                (int)Math.Round(attendancePercentage, MidpointRounding.AwayFromZero);

            Console.WriteLine($"Attendance Roundof percentage: {eligibilityPercentage}%");

        }
    }
}

// 149 attended out of 200 delivered → 74.5%
// Truncate → 74
// Round → 75

