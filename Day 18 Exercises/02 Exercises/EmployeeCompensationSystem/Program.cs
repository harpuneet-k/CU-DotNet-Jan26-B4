namespace EmployeeCompensationSystem
{
    class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public decimal BasicSalary { get; set; }
        public int ExperienceInYears { get; set; }
        public Employee(int id, string name, decimal salary, int years)
        {
            EmployeeId = id;
            EmployeeName = name;
            BasicSalary = salary;
            ExperienceInYears = years;
        }

        public decimal CalculateAnnualSalary()
        {
            decimal annualSalary = BasicSalary * 12;
            return annualSalary;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.WriteLine($"Employee Name: {EmployeeName}");
            Console.WriteLine($"Basic Salary: {BasicSalary:C}");
            Console.WriteLine($"Experience (Years): {ExperienceInYears}");
            Console.WriteLine($"Annual Salary: {CalculateAnnualSalary():C}");
        }

    }

    class PermanentEmployee : Employee
    {
        public PermanentEmployee(int id, string name, decimal salary, int years)
            : base(id, name, salary, years)
        {
            Console.WriteLine("Permanent Employee..");
        }

        public new decimal CalculateAnnualSalary()
        {
            decimal hra =BasicSalary*0.20m;
            decimal spallow = BasicSalary * 0.10m;
            decimal loyaltybonus = 0m;
            if (ExperienceInYears >= 5)
            {
                loyaltybonus=50000m;
            }
            decimal finalSalary = (BasicSalary * 12) + (hra * 12) + (spallow * 12) + loyaltybonus;
            return finalSalary ;
        }
    }

    class ContractEmployee: Employee
    {
        public int ContractDurationInMonths { get; set; }
        decimal bonus = 0m;

        public ContractEmployee(int id, string name, decimal salary, int years, int duration):base(id, name, salary, years)
        {
            ContractDurationInMonths= duration;
        }

        public new decimal CalculateAnnualSalary()
        {
            if (ContractDurationInMonths >= 12)
            {
                bonus = 30000m;
            }
            return (BasicSalary*12)+ bonus;
        }
       
    }

    class InternEmployee : Employee
    {
        public InternEmployee(int id, string name, decimal salary, int years):base(id, name, salary, years)
        {
            Console.WriteLine("Intern class constructor");
        }
        public new decimal CalculateAnnualSalary()
        {
            return BasicSalary*12;
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new PermanentEmployee(101, "A", 40000, 6);
            PermanentEmployee e2 = new PermanentEmployee(102, "B", 40000, 6);

            Employee e3 = new ContractEmployee(103, "Ce", 30000, 2, 14);
            ContractEmployee e4 = new ContractEmployee(104, "D", 30000, 2, 14);

            Employee e5 = new InternEmployee(105, "E", 15000, 0);
            InternEmployee e6 = new InternEmployee(106, "F", 15000, 0);

            Console.WriteLine("\nBase class refernce:");      
            
            e1.DisplayEmployeeDetails();
            Console.WriteLine(e1.CalculateAnnualSalary());

            e3.DisplayEmployeeDetails();
            Console.WriteLine(e3.CalculateAnnualSalary());

            e5.DisplayEmployeeDetails();
            Console.WriteLine(e5.CalculateAnnualSalary());

            Console.WriteLine("\nDerived class refernce:");

            e2.DisplayEmployeeDetails();
            Console.WriteLine(e2.CalculateAnnualSalary());

            e4.DisplayEmployeeDetails();
            Console.WriteLine(e4.CalculateAnnualSalary());

            e6.DisplayEmployeeDetails();
            Console.WriteLine(e6.CalculateAnnualSalary());

        }
    }
}
