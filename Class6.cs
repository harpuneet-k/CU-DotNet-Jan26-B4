using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_system
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            // Temperature reading from sensor (e.g., tenths of °C)
            short sensorReading = 325; // represents 32.5°C

            // Convert to Celsius (double for precision)
            double temperatureCelsius = sensorReading / 10.0;

            // Store multiple readings (example)
            double[] dailyReadings = { 32.5, 33.1, 31.8 };

            // Calculate daily average
            double dailyAverage =
                dailyReadings.Average();

            // Convert average for dashboard display
            int displayTemperature =
                (int)Math.Round(dailyAverage, MidpointRounding.AwayFromZero);

            Console.WriteLine($"Average Temperature: {displayTemperature}°C");

        }
    }
}
