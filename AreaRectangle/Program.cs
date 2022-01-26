using System;

namespace AreaRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int length,width,Area;
            Console.WriteLine("Enter the length:");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the width:");
            width = Convert.ToInt32(Console.ReadLine());
            Area = length * width;
            Console.WriteLine($"The area of the rectangle is {Area} M squared!");
        }
    }
}
