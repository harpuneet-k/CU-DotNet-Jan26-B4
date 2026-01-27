namespace LoanEmiCalc
{
    class Loan
    {
        public string LoanNumber { get; set; }
        public string CustomerName { get; set; }
        public decimal PrincipalAmount { get; set; }

        public int TenureInYears { get; set; }

        public Loan()
        {
            LoanNumber = string.Empty;
            CustomerName = string.Empty;
            PrincipalAmount = 0.0m;
            TenureInYears = 0;

        }

        public Loan(string LNum, string custname, decimal pa, int years)
        {
            LoanNumber = LNum;
            CustomerName = custname;
            PrincipalAmount = pa;
            TenureInYears = years;
        }

        public double CalcEMI()
        {
            decimal interest = PrincipalAmount * 0.10m * TenureInYears; // 10% simple interest
            decimal total = PrincipalAmount + interest;
            decimal emi = total / (TenureInYears * 12);

            //return 10% interest simple
            return (double)emi;
        }
    }

    class HomeLoan : Loan
    {
        //interest rate=8%
        //one-time processing fee=1% of PA

        public HomeLoan(string LNum, string custname, decimal pa, int years)
            : base(LNum, custname, pa, years)
        {
            Console.WriteLine("\nHome Loan Constructor");
        }


        public new double CalcEMI()
        {
            decimal processingFee = PrincipalAmount * 0.01m;
            decimal adjustedPrincipal = PrincipalAmount + processingFee;
            decimal interest = adjustedPrincipal * 0.08m * TenureInYears; // 8% simple interest
            decimal total = adjustedPrincipal + interest;
            decimal emi = total / (TenureInYears * 12);
            return (double)emi;


        }
    }

    class CarLoan : Loan
    {
        //interest rate 9%
        //Insurance charge: Rs 15,000 (added to principal)

        public CarLoan(string LNum, string custname, decimal pa, int years)
            : base(LNum, custname, pa, years)
        {
            Console.WriteLine("\nCar Loan Constructor");
        }
        public new double CalcEMI()
        {
            decimal insuranceCharge = 15000m;
            decimal adjustedPrincipal = PrincipalAmount + insuranceCharge;
            decimal interest = adjustedPrincipal * 0.09m * TenureInYears; // 9% simple interest
            decimal total = adjustedPrincipal + interest;
            decimal emi = total / (TenureInYears * 12);
            return (double)emi;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // 2 OBJ OF HOME LOAN
            // 2 OBJ OF CAR LOAN
            // ADD ALL IN ARRAY OF LOAN
            // CALC EMI FOR EACH LOAN (ON ALL OBJ) AND DISPLAY

            Loan[] loans = new Loan[4];
            loans[0] = new HomeLoan("HL001", "Alice", 500000m, 15);
            loans[1] = new HomeLoan("HL002", "Bob", 750000m, 20);
            loans[2] = new CarLoan("CL001", "Charlie", 300000m, 5);
            loans[3] = new CarLoan("CL002", "Diana", 450000m, 7);

            Console.WriteLine();
            for (int i = 0; i < loans.Length; i++)
            {
                double emi = loans[i].CalcEMI();
                Console.WriteLine($"Loan Number: {loans[i].LoanNumber}, Customer: {loans[i].CustomerName}, EMI: {emi:C}");
            }

        }
    }
}




// TO WRITE:
//1. CONCEPT OF NEW KEYWORD FOR METHOD HIDING
//2. Anonymous Types
