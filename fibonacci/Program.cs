using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static long[] numbers;
        static long fib(int n){
            if(0 == numbers[n]){
                numbers[n] = fib(n-1) + fib(n-2);
            }
            return numbers[n];

        }
        static void Main()
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
            numbers = new long[n + 2];
            numbers[1] = 1;
            numbers[2] = 1;
            long result = fib(n);
            Console.WriteLine($"fibonacci where {n} is {result}");
            Console.ReadLine();
        }
    }
}
