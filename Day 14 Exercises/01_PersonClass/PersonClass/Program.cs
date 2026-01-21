namespace PersonClass
{
    class Employee
    {
        int id;

        public void setId(int id)
        {
            this.id= id;
        }

        public string Name { get; set; }

        private string department;

        public string Department
        {
            get { return department; }
            set { if (value == "Accounts" || value=="Sales" || value=="IT")
                    department = value;
                else
                    department = "Wrong Department Entered"; }
        }

        private int salary;

        public int Salary
        {
            get { return salary; }
            set { if (value>= 50000 && value<= 90000)
                    salary = value; }
        }

        public void display()
        {
            Console.WriteLine($"ID of Employee: {id}");
            Console.WriteLine($"Name of the Employee: {Name}");
            Console.WriteLine($"Department of {Name}: {department}");
            Console.WriteLine($"Salary of {Name}: {salary}");
        } 


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Introducing Classes ...");

            Employee emp = new Employee();
            Employee emp2 = new Employee();


            emp.setId(101);
            emp.Name = "Riya";
            emp.Department = "Liberal Arts";
            emp.Salary = 55000;

            emp2.setId(102);
            emp2.Name = "Prachi";
            emp2.Department = "Accounts";
            emp2.Salary = 34000;

            Console.WriteLine("\n Employee 1 details :\n");
            emp.display();
            Console.WriteLine("\n Employee 2 details :\n");
            emp2.display();

        }
    }
}
