﻿using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3, avarage;

            Console.Write("Enter 1st number :");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number :");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 3rd number :");
            number3 = Convert.ToInt32(Console.ReadLine());

            avarage = (number1 + number2 + number3) / 3;

            Console.Write("Avarage of three numbers is {0}", avarage);

            Console.ReadKey();
           
        }
    }
}
