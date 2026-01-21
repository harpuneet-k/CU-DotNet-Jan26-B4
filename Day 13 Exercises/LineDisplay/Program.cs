namespace LineDisplay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            LinePrint();
            LinePrint('+');
            LinePrint('$', 60);
        }

        static void LinePrint(char ch = '-', int count = 40)
        {
            Console.WriteLine($"\n Printing pattern with:{ch}");
            for (int i = 0; i < count; i++)
            {

                Console.Write(ch);
            }
            Console.WriteLine();
        }
    }
}
