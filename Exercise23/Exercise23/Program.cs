using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some text:");
            string inputText = Console.ReadLine();
            string firstTen = inputText.Substring(0, 10);
            Console.WriteLine(firstTen);
            Console.ReadKey();
        }
    }
}
