using System;

namespace SimpleInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            int P,Time;
            string name;
            double R = 0.1275,Simple;
            Console.WriteLine("Hello, What's your name:");
            name = Console.ReadLine();
            Console.WriteLine($"{name}, Welcome to wakulima loan Facility.Kindly the amount you wish to orrow:");
            P = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Repayment time in months:");
            Time = Convert.ToInt32(Console.ReadLine());
            Simple = P * R * (Time/12);
            Console.WriteLine($"Hello {name}, your principle amount is Ksh {P} at 12.75% will attract an Interest of {Simple}.Total Amount to repay Ksh {Simple + P }.Your monthly installments is KSh {Simple/Time}");
        }
    }
}
