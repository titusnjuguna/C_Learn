using System;

namespace FloatingProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1,num2,Prod;
            Console.WriteLine("Enter num1:");
            num1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter num2:");
            num2 = Convert.ToSingle(Console.ReadLine());
            Prod = num1 * num2;

            Console.WriteLine($"The Product of {num1} and {num2} is {Prod}");
            Console.ReadLine();
        }
    }
}
