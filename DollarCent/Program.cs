using System;

namespace DollarCent
{
    class Program
    {
        static void Main(string[] args)
        {
            double Dollar,Cents;
            
            Console.WriteLine("Enter the Dollar amount:");
            Dollar = Convert.ToDouble(Console.ReadLine());
            Cents = Dollar * 100;
            Console.WriteLine($"You had ${Dollar} and now you have {Cents} Cents");
            Console.ReadKey();
        }
    }
}
