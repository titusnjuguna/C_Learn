using System;

namespace PeriArea_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius;
            double Pi = 3.1456789D,Area, Perimeter;
            Console.WriteLine("Enter the radius of the Circle:");
            radius = Convert.ToInt32(Console.ReadLine());
            Area = 2 * Pi * radius * radius;
            Perimeter = 2 * Pi * radius;
            Console.WriteLine($"The Area of the Circle is {Area} MSq and the perimeter is {Perimeter} M");
            Console.ReadKey();
        }
    }
}
