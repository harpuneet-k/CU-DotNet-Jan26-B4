namespace HeightCalc
{
    class Height
    {
        // Auto-implemented properties for Feet and Inches
        public int Feet { get; set; }
        public decimal Inches { get; set; }


        //Default Constructor
        public Height()
        {
            Feet = 0;
            Inches = 0.0m;
        }

        //Parameterized Constructor
        public Height(int feet, decimal inches)
        {
            Feet = feet;
            Inches = inches;
        }

       

        //method to add two Height objects
        public Height AddHeights(Height h)
        {
            
                            
            int f = h.Feet + this.Feet;
            decimal i = h.Inches + this.Inches;


            if (i >= 12)
            {
                f+= (int)(i / 12);
                i = i % 12;
            }

            Height height = new Height(f, i);
            return height;

        }


        public override string ToString()
        {
            return $"Height-{Feet} feet {Inches:F1} inches";
        }
     }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, printing Height..!");
            Height h1 = new Height(6,4.0m);
            Height h2 = new Height(5,9.0m);

            Console.WriteLine(h1);
            Console.WriteLine(h2);
           
            Height addedHeight =h1.AddHeights(h2);
            Console.WriteLine(addedHeight);

            
        }
    }
}
