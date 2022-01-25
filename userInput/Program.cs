using System;
namespace userInput
{
    class Program
    {
        static void Main(string[] args)
        {
            int numpa;
            Console.WriteLine("Enter the numpa:");
            numpa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You entered {numpa}");

        }
    }
}
