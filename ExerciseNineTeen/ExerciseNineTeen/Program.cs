using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseNineTeen
{
    class Program
    {
        static void Main(string[] args)
        {
            //start the loop for y/n exit here
            while (true)
            {

                Console.Write("Please enter a number: ");
                string inputNumber = Console.ReadLine();
                int numberOne;
                while (!int.TryParse(inputNumber, out numberOne))
                {
                    Console.Write("Sorry, that is not a valid number. Please try again: ");
                    inputNumber = Console.ReadLine();
                }

                Console.Write("Please enter a second number: ");
                string inputNumberTwo = Console.ReadLine();
                int numberTwo;
                while (!int.TryParse(inputNumberTwo, out numberTwo))
                {
                    Console.Write("Sorry, that is not a valid number. Please try again: ");
                    inputNumberTwo = Console.ReadLine();
                }

                //Note I am including the starting number and ending number in this -- not sure if I am supposed to ???

                int sum = 0;
                if (numberOne > numberTwo)
                {
                    for (int i = numberTwo; i <= numberOne; i++)
                    {
                        sum = i + sum;
                    }

                }
                else
                {
                    for (int i = numberOne; i <= numberTwo; i++)
                    {
                        sum = i + sum;
                    }
                }
                Console.WriteLine($"The sum of all the numbers between {numberOne} and {numberTwo} is {sum}");

                //Console.WriteLine(totalSum);
                //Console.WriteLine($"The sum of the numbers between {numberOne} and {numberTwo} are {grandSum}");


                //Section to go again
                Console.WriteLine();

                Console.Write("Would you like to try again? If not press \"n\" to exit. -");
                if (Console.ReadLine().Equals("n", StringComparison.OrdinalIgnoreCase)) break;
                Console.WriteLine();
                Console.WriteLine("Goodbye!");
                Console.ReadKey();

            }



            }
        }
    }

