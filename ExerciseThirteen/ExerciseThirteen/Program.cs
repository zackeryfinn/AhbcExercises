using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseThirteen
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Please provide a number.");
                string input = Console.ReadLine();

                int myNumber;
                bool parsed = Int32.TryParse(input, out myNumber);

                while (myNumber >= 0)
                {
                    Console.WriteLine(myNumber);
                    myNumber--;
                }


                //section to see if you want to do it again
                Console.WriteLine("Would you like to try again ? (y / n)");

                if (Console.ReadLine().ToLower() != "y") break;



            }








        }
    }
}
