namespace Week2Assessment
{
    internal class InsuranceSummarySystem
    {
        static void Main(string[] args)
        {

            // Develop a .NET Console Application that captures basic insurance policy data
            // for a small set of customers, processes the data using value types and strings,
            // and displays a formatted insurance summary report.

            string[] policyHolderNames= new string[5];
            decimal[] annualPremiums= new decimal[5];



            //1.Input
            for (int i = 0; i < policyHolderNames.Length; i++)
            {
                Console.Write($"Enter the name of policy holder {i + 1}: ");
                policyHolderNames[i] = Console.ReadLine();
                Console.Write($"Enter the annual premium for {policyHolderNames[i]}: ");
                annualPremiums[i] = Convert.ToDecimal(Console.ReadLine());
                // Input validation
                if (policyHolderNames[i] == "")
                {
                    Console.WriteLine("Policy holder name cannot be empty. Please re-enter.");
                    i--;
                }
                if (annualPremiums[i] < 0)
                {
                    Console.WriteLine("Annual premium cannot be negative. Please re-enter.");
                    i--; // Decrement i to repeat the input for the same policy holder
                }
            }

            //2.Processing (Value Types)
            decimal totalPremium = 0;
            for (int i = 0; i < annualPremiums.Length; i++)
            {
                totalPremium += annualPremiums[i];
            }
            decimal averagePremium = totalPremium / annualPremiums.Length;
            decimal minPremium = annualPremiums.Min();
            decimal maxPremium = annualPremiums.Max();
                   
            string category="";

            // Output Report
            Console.WriteLine("\nInsurance Premium Summary:");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("\n Name \t Premium \t Category");
            for (int i = 0; i < policyHolderNames.Length; i++)
            {
                if (annualPremiums[i] < 10000)
                {
                    category = "Low";
                }
                else if (annualPremiums[i] >= 10000 && annualPremiums[i] < 25000)
                {
                    category = "Medium";
                }
                else
                {
                    category = "Premium";
                }
                Console.WriteLine($"{policyHolderNames[i].ToUpper()} \t {annualPremiums[i]:C} \t {category}");
            }
            Console.WriteLine($"\nTotal Premium: {totalPremium:C}");
            Console.WriteLine($"Average Premium: {averagePremium:C}");
            Console.WriteLine($"Highest Premium: {maxPremium:C}");
            Console.WriteLine($"Lowest Premium: {minPremium:C}");

        }


    }
}
