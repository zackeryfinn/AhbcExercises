using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFifteen
{
    class Program
    {
        static void Main(string[] args)
        {
                //yes&no looping loop starts here
                while (true)
                {



                    Console.WriteLine("If you give me a number, I'll give you all the cubes from 1 to that number. ");
                    Console.Write("Enter your number here: ");
                    string inputNumber = Console.ReadLine();
                    int number;
                    while (!int.TryParse(inputNumber, out number))
                    {
                        Console.Write("Sorry, that is not a valid input. Please try again: ");
                        inputNumber = Console.ReadLine();
                    }


                    for (int start = 1; start <= number; start++)
                    {
                        Console.Write(start*start*start + " ");

                    }

                    Console.WriteLine();
                    Console.WriteLine();

                    Console.Write("Would you like to try again ? If no press \"n\" to exit. -");
                    if (Console.ReadLine().Equals("n", StringComparison.OrdinalIgnoreCase)) break;
                    Console.WriteLine();
                }

            }

        }
    }




