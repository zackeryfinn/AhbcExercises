using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEighteen
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                ForSum();

                //Section to go again
                Console.WriteLine();

                Console.Write("Would you like to try again? If not press \"n\" to exit. -");
                if (Console.ReadLine().Equals("n", StringComparison.OrdinalIgnoreCase)) break;
                Console.WriteLine();
                
                Console.ReadKey();

            }


        }

        public static void ForSum()
        {
            Console.Write("Please enter a number: ");
            string inputNumber = Console.ReadLine();
            int numberOne;
            while (!int.TryParse(inputNumber, out numberOne))
            {
                Console.Write("Sorry, that is not a valid number. Please try again: ");
                inputNumber = Console.ReadLine();
            }
            int sum = 0;
                for (int i = 0; i <= numberOne; i++)
                {
                    sum = i + sum;
                }
            Console.WriteLine($"The sum of all the numbers between 1 and {numberOne} is {sum}");

        }

    }
}
