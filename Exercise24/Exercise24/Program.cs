using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some text:");
            string inputText = Console.ReadLine();
            string lastTen = inputText.Substring(Math.Max(0, inputText.Length - 10));
            Console.WriteLine(lastTen);
            Console.ReadKey();


        }
    }
}
