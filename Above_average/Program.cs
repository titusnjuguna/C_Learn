using System;

namespace Above_average
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] num = new int[10];
            int sum=0,avg=0,below=0, above=0;
            for(int i=0;i<10;i++){
                Console.Write($"Number {i + 1}:");
                num[i] = Convert.ToInt32(Console.ReadLine());
                sum += num[i];
            }
            avg = sum / 10;

            for(int i =0;i<10;i++){
                if(num[i]<avg){
                    below++;
                }else{
                    above++;
                }
            }
            
            Console.WriteLine($"The average is : {avg}");
            Console.WriteLine($"The numbers above the average are: {above}");
            Console.WriteLine($"The numbers below the average are: {below}");
            Console.ReadKey();

            
        }
    }
}
