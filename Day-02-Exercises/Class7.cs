using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university_system
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            // Final score after evaluation
            double finalScore = 87.6;

            // Validate score range
            if (finalScore < 0 || finalScore > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(finalScore),
                    "Score must be between 0 and 100.");
            }

            // Convert score to integer percentage
            int roundedScore =
                (int)Math.Round(finalScore, MidpointRounding.AwayFromZero);

            // Map score to grade (stored as byte)
            byte grade;

            if (roundedScore >= 90)
                grade = 10;       // A+
            else if (roundedScore >= 80)
                grade = 9;        // A
            else if (roundedScore >= 70)
                grade = 8;        // B
            else if (roundedScore >= 60)
                grade = 7;        // C
            else if (roundedScore >= 50)
                grade = 6;        // D
            else
                grade = 5;        // Fail

            Console.WriteLine($"Score: {finalScore}");
            Console.WriteLine($"Grade Code: {grade}");

        }
    }
}
// Validation Choices
// Score is validated to be within 0–100 before conversion.
// Prevents invalid values that could cause incorrect grading or overflow.

// Casting Choices
// double → int conversion uses rounding, not truncation.
// Prevents unfair grade reduction.
// int → byte assignment is safe because grade values are controlled and within range.

