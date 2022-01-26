using System;

namespace Neg_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseNumber, powerNumber;

            Console.Write("Enter base number :");
            baseNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter exponent number :");
            powerNumber = Convert.ToDouble(Console.ReadLine());

            double returnNumber = Math.Pow(baseNumber, powerNumber);
            Console.WriteLine($"{baseNumber}^{powerNumber} = {returnNumber}");

            Console.ReadLine();
            
        }
    }
}
