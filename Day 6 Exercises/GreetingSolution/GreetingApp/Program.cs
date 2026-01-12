using GreetingLibrary;
namespace GreetingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("Enter the Name: ");
            string name = Console.ReadLine();
            Console.WriteLine(GreetingHelper.GetGreeting(name)+" Greetings of the day..!!");
        }
    }
}
