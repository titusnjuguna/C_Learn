using System;

namespace Count_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string Word;
            Console.WriteLine("Start Typing...:");
            Word = Console.ReadLine();
            string[] words = Word.Split();
            Console.WriteLine($"The sentence has {words.Length} words");
        }
    }
}
