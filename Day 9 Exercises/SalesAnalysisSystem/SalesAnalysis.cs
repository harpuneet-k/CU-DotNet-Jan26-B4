namespace SalesAnalysisSystem
{
    internal class SalesAnalysis
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            // Develop a Weekly Sales Analysis System in .NET
            // that stores, processes, and reports sales data
            // for 7 consecutive days using array-based logic.

            decimal[] weeklySales = new decimal[7];
            for (int i = 0; i < weeklySales.Length; i++)
            {
                Console.Write($"Enter sales for day {i + 1}: ");
                 weeklySales[i] = Convert.ToDecimal(Console.ReadLine());
                // Input validation
                if (weeklySales[i] < 0)
                {
                    Console.WriteLine("Sales cannot be negative. Please re-enter.");
                    i--; // Decrement i to repeat the input for the same day
                }

            }
            decimal totalSales = 0;
            for (int i = 0; i < weeklySales.Length; i++)
            {
                totalSales += weeklySales[i];
            }
            decimal averageSales = totalSales / weeklySales.Length;

            decimal lowestsale = weeklySales.Min();
            int positionLowest = Array.IndexOf(weeklySales, lowestsale) + 1;
            decimal highestsale = weeklySales.Max();
            int positionHighest = Array.IndexOf(weeklySales, highestsale) + 1;

            //Sales Categorization
            string[] category= new string[7];
            for(int i=0; i<weeklySales.Length; i++)
            {
                if(weeklySales[i]<5000)
                {
                    category[i]="Low";
                }
                else if(weeklySales[i]>=5000 && weeklySales[i]<15000)
                {
                    category[i]="Medium";
                }
                else
                {
                    category[i]="High";
                }
            }

            
            
            //output report
            Console.WriteLine("\nWeekly Sales Report:");
            Console.WriteLine("---------------------");
            Console.WriteLine($"\nTotal Sales for the week: {totalSales:C}");
            Console.WriteLine($"Average Daily Sale:{averageSales:C} ");
            Console.WriteLine($"\nLowest Sale: {lowestsale:C} on Day {positionLowest}");
            Console.WriteLine($"Highest Sale: {highestsale:C} on Day {positionHighest}");

            // days recorded sales greater than weeky average
            int count = 0;
            for (int i = 0; i < weeklySales.Length; i++)
            {
                if (weeklySales[i] > averageSales)
                {
                    count += 1;
                }
            }
            Console.WriteLine($"\nDays with sales greater than weekly average:{count}");


            //day wise category summary
            Console.WriteLine("\nDay-wise Sales Category:");
            for (int i = 0; i < category.Length; i++)
            {
                Console.WriteLine($"Day {i + 1}: {category[i]}");
            }

        }
    }
}
