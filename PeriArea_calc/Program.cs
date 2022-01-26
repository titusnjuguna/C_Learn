using System;

namespace PeriArea_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            int length,Area,Perimeter;
            Console.WriteLine("Enter the length of the Square:");
            length = Convert.ToInt32(Console.ReadLine());
            Area = length * length ;
            Perimeter = length * 4;
            Console.WriteLine($"The Area of the Square is {Area} MSq and the perimeter is {Perimeter} M");
        }
    }
}
