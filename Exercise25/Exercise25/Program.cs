using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some a sentence: ");
            string inputSentence = Console.ReadLine();
            string[] words = inputSentence.Split(' ');

            foreach (var word in words)
            {
                System.Console.WriteLine($"{word}");
            }

            Console.ReadKey();
        }
    }
}
