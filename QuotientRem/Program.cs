using System;

namespace QuotientRem
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,num2, quotient, rem;
            Console.WriteLine("Enter num1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2:");
            num2 = Convert.ToInt32(Console.ReadLine());
            quotient = num1/num2;
            rem = num1%num2;
            Console.WriteLine($"Quotient {quotient} Rem {rem}");
            Console.ReadLine();
        }
    }
}
